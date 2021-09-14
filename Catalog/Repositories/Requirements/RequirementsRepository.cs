using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Database;
using Catalog.Models.Questionnaires;
using Catalog.Models.Requirements;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories.Requirements
{
    public class RequirementsRepository : RepositoryBase<Requirement>, IRequirementsRepository
    {
        private ApplicationDbContext _db;
        
        public RequirementsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public async Task<List<Requirement>> GetAllWithChildren()
        {
            var requirements = await _db.Requirements
                .Include(x => x.ComplianceProcess)
                .Include(x => x.ComplianceRisk)
                .Include(x => x.RelationsStage)
                .Include(x => x.AnyTriggerSet)
                .Include(x => x.RequiredTriggerSet)
                .ToListAsync();
            return requirements;
        }

        public async Task<List<Requirement>> GenerateRequirementsOffer(Questionnaire requestQuestionnaire)
        {
            var offer = await _db.Requirements
                .Include(x => x.RequiredTriggerSet)
                .Where(x => x.RequiredTriggerSet.RequiredTriggers
                    .All(z => requestQuestionnaire.Triggers.Contains(z))).ToListAsync();
            return offer;
        }
    }
}