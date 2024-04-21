using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using ApiProject.Persistence.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        //private DbSet<T> Table { get => appDbContext.Set<T>(); }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteasync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
