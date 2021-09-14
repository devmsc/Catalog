using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Database;
using Catalog.Models.Questions;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories.Questions
{
    public class QuestionsRepository : RepositoryBase<Question>, IQuestionsRepository
    {
        private ApplicationDbContext _db;
        
        public QuestionsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Question> GetWithTriggers(Guid id)
        {
            return await _db.Questions
                .Include(x => x.Triggers)
                .FirstAsync(x => x.Id == id);
        }
    }
}