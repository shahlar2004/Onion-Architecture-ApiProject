using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepoitory<T> where T : class, IEntitieBase, new()
    {
        public Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentpage = 1, int pagesize = 3)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
