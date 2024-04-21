using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepoitory<T> where T : class, IEntitieBase, new()
    {
        private readonly DbContext dbContext;

        public ReadRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        private DbSet<T> Table { get=>dbContext.Set<T>(); } 




        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;

            if(!enableTracking) queryable=queryable.AsNoTracking();
            if (predicate is not null) queryable=queryable.Where(predicate);
            if(include is not null) queryable=include(queryable);

            if(orderBy is not null) 
                return await orderBy(queryable).ToListAsync();  

            return await queryable.ToListAsync();   
            
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if(!enableTracking) queryable = queryable.AsNoTracking();
            if(include is not null) queryable= include(queryable);
            return await queryable.SingleOrDefaultAsync(predicate);

        }



        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentpage = 1, int pagesize = 3)
        {
            IQueryable<T> queryable = Table;

            if(!enableTracking) queryable=queryable.AsNoTracking(); 
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (include is not null) queryable=include(queryable);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentpage-1)*pagesize).Take(pagesize).ToListAsync();
            return await queryable.Skip((currentpage - 1) * pagesize).Take(pagesize).ToListAsync();
           
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Table.AsNoTracking();
            if (predicate is not null) Table.Where(predicate);
         
            return await Table.CountAsync();
        }

        public  IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking) Table.AsNoTracking();

             return Table.Where(predicate);
        }



     
    }
}
