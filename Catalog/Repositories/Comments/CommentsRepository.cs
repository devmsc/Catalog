using Catalog.Database;
using Catalog.Models.Comments;

namespace Catalog.Repositories.Comments
{
    public class CommentsRepository : RepositoryBase<Comment>, ICommentsRepository
    {
        public CommentsRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}