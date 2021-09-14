using MediatR;

namespace Catalog.Features.ComplianceProcessesFeatures.AddComplianceProcess
{
    public class AddComplianceProcessRequest : IRequest<AddComplianceProcessResponse>
    {
        public string Content { get; set; }
    }
}