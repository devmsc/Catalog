using Catalog.Database;
using Catalog.Models.Users;

namespace Catalog.Repositories.Users
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}