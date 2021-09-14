using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Models.Base;
using Catalog.Models.Questionnaires;

namespace Catalog.Models.Questions
{
    public class Question : ModelBase
    {
        public Question()
        {
            
        }
        public Question(string content, QuestionType questionType, List<Trigger> triggers)
        {
            Content = content;
            QuestionType = questionType;
            Triggers = triggers;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = CreatedAt;
        }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Content { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<Trigger> Triggers { get; set; } = new();
        
        public List<Questionnaire> Questionnaires { get; set; } = new();
        public int? Number { get; private set; }
        
        public void SetNumber(int number)
        {
            Number = number;
        }
    }
}