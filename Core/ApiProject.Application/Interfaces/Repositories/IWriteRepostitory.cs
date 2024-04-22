using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Interfaces.Repositories
{
    public interface IWriteRepostitory<T> where T : class, IEntitieBase, new()
    {

        Task AddAsync(T entity);

        Task AddRangeAsync(IList<T> entities);

        Task<T> UpdateAsync(T entity);

       // Task SoftDeleteasync(T entity);
            
        Task HardDeleteAsync(T entity);
    }
}
