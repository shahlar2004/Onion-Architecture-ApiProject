//using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Repositories
{
    public class WriteRepository<T> 
    {



        private readonly DbContext dbContext;

        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

       // private DbSet<T> Table { get => dbContext.Set<T>(); }
            


        public async Task AddAsync(T entity)
        {
        }

        public Task AddRangeAsync(IList<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task HardDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
