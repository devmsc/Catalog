using System;
using System.Collections.Generic;
using MediatR;

namespace Catalog.Features.RequirementFeatures.AddRequirement
{
    public class AddRequirementRequest : IRequest<AddRequirementResponse>
    {
        public Guid RelationStage { get; set; }
        public Guid ComplianceRisk { get; set; }
        public Guid ComplianceProcess { get; set; }
        public string Conclusion { get; set; }
        public List<Guid> AnyTriggerSet { get; set; }
        public List<Guid> RequiredTriggerSet { get; set; }
    }
}