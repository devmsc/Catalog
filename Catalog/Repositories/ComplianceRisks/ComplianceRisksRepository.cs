using Catalog.Database;
using Catalog.Models.Requirements;

namespace Catalog.Repositories.ComplianceRisks
{
    public class ComplianceRisksRepository : RepositoryBase<ComplianceRisk>, IComplianceRisksRepository
    {
        public ComplianceRisksRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}