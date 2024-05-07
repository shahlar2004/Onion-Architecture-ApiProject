using ApiProject.Application.Interfaces.Repositories;
using ApiProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepoitory<T>() where T : class, IEntitieBase, new();
        IWriteRepostitory<T> GetWriteRepostitory<T>() where T: class, IEntitieBase, new();
        Task<int> SaveAsync();
        int Save();

    }
}
