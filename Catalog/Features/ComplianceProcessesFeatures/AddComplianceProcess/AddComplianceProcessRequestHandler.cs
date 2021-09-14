using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Requirements;
using Catalog.Repositories.ComplianceProcesses;
using MediatR;

namespace Catalog.Features.ComplianceProcessesFeatures.AddComplianceProcess
{
    public class AddComplianceProcessRequestHandler : IRequestHandler<AddComplianceProcessRequest, AddComplianceProcessResponse>
    {
        private IComplianceProcessesRepository _complianceProcessesRepository;

        public AddComplianceProcessRequestHandler(IComplianceProcessesRepository complianceProcessesRepository)
        {
            _complianceProcessesRepository = complianceProcessesRepository;
        }

        public async Task<AddComplianceProcessResponse> Handle(AddComplianceProcessRequest request, CancellationToken cancellationToken)
        {
            var complianceProcess = new ComplianceProcess(request.Content);
            var complianceProcessId = await _complianceProcessesRepository.Insert(complianceProcess, cancellationToken);
            return await Task.FromResult(AddComplianceProcessResponse.GetSuccess(complianceProcessId));
        }
    }
}