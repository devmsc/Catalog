using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Base;

namespace Catalog.Repositories
{
    public interface IRepositoryBase<T> where T: ModelBase
    {
        Task<Guid> Insert(T model, CancellationToken cancellationToken);
        Task<int> Delete(Guid id, CancellationToken cancellationToken);
        Task<int> Update(T model, CancellationToken cancellationToken);
        Task<T> GetById(Guid id);
        Task<T> GetByIdOrNull(Guid id);
        Task<List<T>> GetAll();
        Task<List<T>> GetAllWithDeleted();
        Task<List<T>> GetByAllByFilter(Expression<Func<T, bool>> filterDefinition);
        Task<T> GetFirstOrDefaultByFilter(Expression<Func<T, bool>> filterDefinition);
    }
}