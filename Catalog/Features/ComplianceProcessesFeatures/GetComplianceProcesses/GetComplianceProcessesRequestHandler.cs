using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.ComplianceProcesses;
using MediatR;

namespace Catalog.Features.ComplianceProcessesFeatures.GetComplianceProcesses
{
    public class GetComplianceProcessesRequestHandler : IRequestHandler<GetComplianceProcessesRequest, GetComplianceProcessesResponse>
    {
        private IComplianceProcessesRepository _complianceProcessesRepository;

        public GetComplianceProcessesRequestHandler(IComplianceProcessesRepository complianceProcessesRepository)
        {
            _complianceProcessesRepository = complianceProcessesRepository;
        }

        public async Task<GetComplianceProcessesResponse> Handle(GetComplianceProcessesRequest request, CancellationToken cancellationToken)
        {
            var complianceProcesses = await _complianceProcessesRepository.GetAll();
            return await Task.FromResult(GetComplianceProcessesResponse.GetSuccess(complianceProcesses));
        }
    }
}