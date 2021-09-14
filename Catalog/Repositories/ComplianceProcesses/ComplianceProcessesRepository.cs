using Catalog.Database;
using Catalog.Models.Requirements;

namespace Catalog.Repositories.ComplianceProcesses
{
    public class ComplianceProcessesRepository : RepositoryBase<ComplianceProcess>, IComplianceProcessesRepository
    {
        public ComplianceProcessesRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}