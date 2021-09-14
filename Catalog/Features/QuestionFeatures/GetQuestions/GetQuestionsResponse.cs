using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Models.Questions;
using Catalog.Models.Responses;

namespace Catalog.Features.QuestionFeatures.GetQuestions
{
    public class GetQuestionsResponse : ResponseBaseModel<List<GetAllQuestionsDto>>
    {
        public static GetQuestionsResponse GetSuccess(List<Question> questions) =>
            new GetQuestionsResponse()
            {
                Data = ConvertToDto(questions),
                Message = "Вопросы получены",
                ResponseStatus = ResponseStatus.Success
            };

        private static List<GetAllQuestionsDto> ConvertToDto(List<Question> questions)
        {
            return questions.Select(question => new GetAllQuestionsDto(question)).ToList();
        }
    }
    
    public class GetAllQuestionsDto
    {
        public GetAllQuestionsDto(Question question)
        {
            Id = question.Id;
            Number = question.Number;
            Content = question.Content;
            CreatedAt = question.CreatedAt;
            UpdatedAt = question.UpdatedAt;
            QuestionType = question.QuestionType;
        }
        public Guid Id { get; set; }
        public int? Number { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}