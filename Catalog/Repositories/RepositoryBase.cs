using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Catalog.Database;
using Catalog.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : ModelBase
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public async Task<Guid> Insert(T model, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(model, cancellationToken);
            var result = await _db.SaveChangesAsync(cancellationToken);
            if (result > 0)
            {
                return model.Id;
            }
            throw new Exception("Не удалось добавить запись в базу данных");
        }

        public async Task<int> Delete(Guid id, CancellationToken cancellationToken)
        {
            var item = await _dbSet.SingleOrDefaultAsync(x => x.Id == id, cancellationToken: cancellationToken);
            _dbSet.Remove(item);
            return await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> Update(T model, CancellationToken cancellationToken)
        {
            _db.Entry(model).State = EntityState.Modified;
            return await _db.SaveChangesAsync(cancellationToken);
        }
        
        public async Task<T> GetById(Guid id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task<T> GetByIdOrNull(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<List<T>> GetAllWithDeleted()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<List<T>> GetByAllByFilter(Expression<Func<T, bool>> filterDefinition)
        {
            return await _dbSet.Where(filterDefinition).ToListAsync();
        }

        public async Task<T> GetFirstOrDefaultByFilter(Expression<Func<T, bool>> filterDefinition)
        {
            return await _dbSet.Where(filterDefinition).FirstOrDefaultAsync();
        }
    }
}