using System;
using System.Collections.Generic;
using Catalog.Models.Base;

namespace Catalog.Models.Requirements
{
    public class RelationStage : ModelBase
    {
        public RelationStage(string content)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Requirement> Requirements { get; set; }
        public string Content { get; set; }
    }
}