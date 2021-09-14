using Catalog.Database;
using Catalog.Models.Requests;

namespace Catalog.Repositories.Requests
{
    public class RequestsRepository : RepositoryBase<Request>, IRequestsRepository
    {
        public RequestsRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}