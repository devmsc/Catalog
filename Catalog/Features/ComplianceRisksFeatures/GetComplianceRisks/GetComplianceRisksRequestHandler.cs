using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.ComplianceRisks;
using MediatR;

namespace Catalog.Features.ComplianceRisksFeatures.GetComplianceRisks
{
    public class GetComplianceRisksRequestHandler : IRequestHandler<GetComplianceRisksRequest, GetComplianceRisksResponse>
    {
        private IComplianceRisksRepository _complianceRisksRepository;

        public GetComplianceRisksRequestHandler(IComplianceRisksRepository complianceRisksRepository)
        {
            _complianceRisksRepository = complianceRisksRepository;
        }

        public async Task<GetComplianceRisksResponse> Handle(GetComplianceRisksRequest request, CancellationToken cancellationToken)
        {
            var complianceRisks = await _complianceRisksRepository.GetAll();
            return await Task.FromResult(GetComplianceRisksResponse.GetSuccess(complianceRisks));
        }
    }
}