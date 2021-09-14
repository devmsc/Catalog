using System;
using Catalog.Models.Requirements;

namespace Catalog.Models.DTO
{
    public class ComplianceProcessDto
    {
        public ComplianceProcessDto(ComplianceProcess complianceProcess)
        {
            Id = complianceProcess.Id;
            Content = complianceProcess.Content;
            CreatedAt = complianceProcess.CreatedAt;
            UpdatedAt = complianceProcess.UpdatedAt;
        }
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}