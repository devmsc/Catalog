using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.Requirements;
using MediatR;

namespace Catalog.Features.RequirementFeatures.GetRequirements
{
    public class GetRequirementsRequestHandler : IRequestHandler<GetRequirementsRequest, GetRequirementsResponse>
    {
        private IRequirementsRepository _requirementsRepository;

        public GetRequirementsRequestHandler(IRequirementsRepository requirementsRepository)
        {
            _requirementsRepository = requirementsRepository;
        }

        public async Task<GetRequirementsResponse> Handle(GetRequirementsRequest request, CancellationToken cancellationToken)
        {
            var requirements = await _requirementsRepository.GetAllWithChildren();
            return await Task.FromResult(GetRequirementsResponse.GetSuccess(requirements));
        }
    }
}