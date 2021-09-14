using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Requirements;
using Catalog.Repositories.ComplianceRisks;
using MediatR;

namespace Catalog.Features.ComplianceRisksFeatures.AddComplianceRisk
{
    public class AddComplianceRiskRequestHandler : IRequestHandler<AddComplianceRiskRequest, AddComplianceRiskResponse>
    {
        private IComplianceRisksRepository _complianceRisksRepository;

        public AddComplianceRiskRequestHandler(IComplianceRisksRepository complianceRisksRepository)
        {
            _complianceRisksRepository = complianceRisksRepository;
        }

        public async Task<AddComplianceRiskResponse> Handle(AddComplianceRiskRequest request, CancellationToken cancellationToken)
        {
            var complianceRisk = new ComplianceRisk(request.Content);
            var complianceRiskId = await _complianceRisksRepository.Insert(complianceRisk, cancellationToken);
            return await Task.FromResult(AddComplianceRiskResponse.GetSuccess(complianceRiskId));
        }
    }
}