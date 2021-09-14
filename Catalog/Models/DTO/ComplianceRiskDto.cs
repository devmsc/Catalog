using System;
using Catalog.Models.Requirements;

namespace Catalog.Models.DTO
{
    public class ComplianceRiskDto
    {
        public ComplianceRiskDto(ComplianceRisk complianceRisk)
        {
            Id = complianceRisk.Id;
            Content = complianceRisk.Content;
            CreatedAt = complianceRisk.CreatedAt;
            UpdatedAt = complianceRisk.UpdatedAt;
        }
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}