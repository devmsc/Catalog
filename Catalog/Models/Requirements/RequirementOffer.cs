using System;
using System.Collections.Generic;
using System.IO;
using Catalog.Models.Base;

namespace Catalog.Models.Requirements
{
    public class RequirementOffer : ModelBase
    {
        public RequirementOffer(List<Requirement> requirements)
        {
            Requirements = requirements;
        }
        public List<Requirement> Requirements { get; set; }
    }

    public class RequirementConclusion : ModelBase
    {
        public RequirementConclusion(Requirement requirement)
        {
            EksLink = requirement.EksLink;
            Conclusion = requirement.Conclusion;
        }

        public string Conclusion { get; set; }
        public string EksLink { get; set; }
        public RequirementConclusionStatus RequirementConclusionStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public enum RequirementConclusionStatus
    {
        Pending,
        Approved
    }
}