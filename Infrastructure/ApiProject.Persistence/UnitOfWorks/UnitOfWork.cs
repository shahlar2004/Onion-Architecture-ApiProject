using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Persistence.Context;
using ApiProject.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async ValueTask DisposeAsync()=> await  appDbContext.DisposeAsync();

        public int Save() => appDbContext.SaveChanges();
      
        public async Task<int> SaveAsync()=> await appDbContext.SaveChangesAsync();


        IReadRepository<T> IUnitOfWork.GetReadRepoitory<T>() => new ReadRepository<T>(appDbContext);
     

        IWriteRepostitory<T> IUnitOfWork.GetWriteRepostitory<T>()=> new WriteRepository<T>(appDbContext);   
      
    }
}
