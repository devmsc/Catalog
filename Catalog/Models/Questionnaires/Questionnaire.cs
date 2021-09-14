using System;
using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Questions;
using Catalog.Models.Requests;

namespace Catalog.Models.Questionnaires
{
    public class Questionnaire : ModelBase
    {
        public Questionnaire()
        {
            
        }
        public Questionnaire(List<Question> questions)
        {
            Questions = questions;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Trigger> Triggers { get; set; } = new();
        public List<Question> Questions { get; set; } = new();
        public Guid RequestId { get; set; }
        public Request Request { get; set; }
    }
}