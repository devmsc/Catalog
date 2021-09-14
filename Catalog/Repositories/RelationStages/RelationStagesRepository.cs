using Catalog.Database;
using Catalog.Models.Requirements;

namespace Catalog.Repositories.RelationStages
{
    public class RelationStagesRepository : RepositoryBase<RelationStage>, IRelationStagesRepository
    {
        public RelationStagesRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}