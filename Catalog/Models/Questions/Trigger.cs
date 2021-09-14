using System;
using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Questionnaires;
using Catalog.Models.Requirements;

namespace Catalog.Models.Questions
{
    public class Trigger : ModelBase
    {
        public Trigger(string content)
        {
            Content = content;
            TriggerStatus = TriggerStatus.Actual;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public Question Question { get; set; }
        public Guid QuestionId { get; set; }
        public List<Questionnaire> Questionnaires { get; set; }
        public List<AnyTriggerSet> AnyTriggerSets { get; set; }
        public List<RequiredTriggerSet> RequiredTriggerSets { get; set; }
        public string Content { get; set; }
        public TriggerStatus TriggerStatus { get; set; }
        
        public void SetStatus(TriggerStatus status)
        {
            TriggerStatus = status;
        }
    }

    public enum TriggerStatus
    {
        Actual,
        Redundant
    }
    
}