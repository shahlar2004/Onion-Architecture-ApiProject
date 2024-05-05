using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using ApiProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Repository
{
    public class WriteRepository<T> : IWriteRepostitory<T> where T : class, IEntitieBase, new()
    {
        private readonly AppDbContext appDbContext;

        public WriteRepository( AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        private DbSet<T> Table { get => appDbContext.Set<T>(); }   

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entity)
        {
            await Table.AddRangeAsync(entity);
        }

        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() =>Table.Remove(entity));
        }



        public async Task HardRangeDeleteAsync(IList<T> entity)
        {
           await Task.Run(()=>Table.RemoveRange(entity));
        }

 

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() =>Table.Update(entity));
            return entity;
        }


    }
}
