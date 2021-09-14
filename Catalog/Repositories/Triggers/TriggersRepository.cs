using Catalog.Database;
using Catalog.Models.Questions;

namespace Catalog.Repositories.Triggers
{
    public class TriggersRepository : RepositoryBase<Trigger>, ITriggersRepository
    {
        public TriggersRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}