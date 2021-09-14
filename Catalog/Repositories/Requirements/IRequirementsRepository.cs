using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Models.Questionnaires;
using Catalog.Models.Requirements;

namespace Catalog.Repositories.Requirements
{
    public interface IRequirementsRepository : IRepositoryBase<Requirement>
    {
        Task<List<Requirement>> GetAllWithChildren();
        Task<List<Requirement>> GenerateRequirementsOffer(Questionnaire requestQuestionnaire);
    }
}