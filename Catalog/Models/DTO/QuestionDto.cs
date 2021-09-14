using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Features.QuestionFeatures.GetQuestion;
using Catalog.Models.Questions;

namespace Catalog.Models.DTO
{
    public class QuestionDto
    {
        public QuestionDto(Question question)
        {
            Id = question.Id;
            Number = question.Number;
            Content = question.Content;
            CreatedAt = question.CreatedAt;
            UpdatedAt = question.UpdatedAt;
            Triggers = ConvertToDto(question.Triggers);
            QuestionType = question.QuestionType;
        }
        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<TriggerDto> Triggers { get; set; }
        private List<TriggerDto> ConvertToDto(List<Trigger> triggers)
        {
            return triggers.Select(trigger => new TriggerDto(trigger)).ToList();
        }
    }
}