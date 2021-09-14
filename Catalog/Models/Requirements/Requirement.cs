using System;
using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Requests;

namespace Catalog.Models.Requirements
{
    public class Requirement : ModelBase
    {
        public Requirement()
        {
            
        }
        public Requirement(RelationStage relationsStage, ComplianceRisk complianceRisk, ComplianceProcess complianceProcess, string conclusion, 
            AnyTriggerSet anyTriggerSet, RequiredTriggerSet requiredTriggerSet)
        {
            RelationsStage = relationsStage;
            ComplianceRisk = complianceRisk;
            ComplianceProcess = complianceProcess;
            Conclusion = conclusion;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public RelationStage RelationsStage { get; set; }
        public ComplianceRisk ComplianceRisk { get; set; }
        public ComplianceProcess ComplianceProcess { get; set; }
        public string Conclusion { get; set; }
        public AnyTriggerSet AnyTriggerSet { get; set; }
        public RequiredTriggerSet RequiredTriggerSet { get; set; }
        public string EksLink { get; set; }
    }
}