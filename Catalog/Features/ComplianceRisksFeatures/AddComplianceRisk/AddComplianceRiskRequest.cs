using MediatR;

namespace Catalog.Features.ComplianceRisksFeatures.AddComplianceRisk
{
    public class AddComplianceRiskRequest : IRequest<AddComplianceRiskResponse>
    {
        public string Content { get; set; }
    }
}