using System.Collections.Generic;
using Catalog.Models.Questions;
using MediatR;

namespace Catalog.Features.QuestionFeatures.AddQuestion
{
    public class AddQuestionRequest : IRequest<AddQuestionResponse>
    {
        public string Content { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<string> Triggers { get; set; }
    }
}