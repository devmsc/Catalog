using System;
using Catalog.Models.Requirements;

namespace Catalog.Models.DTO
{
    public class RelationStageDto
    {
        public RelationStageDto(RelationStage relationStage)
        {
            Id = relationStage.Id;
            Content = relationStage.Content;
            CreatedAt = relationStage.CreatedAt;
            UpdatedAt = relationStage.UpdatedAt;
        }

        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}