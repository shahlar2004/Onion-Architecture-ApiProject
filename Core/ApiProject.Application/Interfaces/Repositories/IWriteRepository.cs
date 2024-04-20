using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class,IEntitieBase,new()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entity);
        Task<T> UpdateAsync(T entity);

        Task HardDeleteAsync(T entity);

        Task SoftDeleteAsync(T entity); 

        

    }
}
