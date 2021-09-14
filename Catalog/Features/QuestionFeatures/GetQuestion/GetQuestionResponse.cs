using Catalog.Models.DTO;
using Catalog.Models.Questions;
using Catalog.Models.Responses;

namespace Catalog.Features.QuestionFeatures.GetQuestion
{
    public class GetQuestionResponse : ResponseBaseModel<QuestionDto>
    {
        public static GetQuestionResponse GetSuccess(Question question) =>
            new GetQuestionResponse()
            {
                Data = ConvertToDto(question),
                Message = "Вопрос получен",
                ResponseStatus = ResponseStatus.Success
            };
        
        private static QuestionDto ConvertToDto(Question question)
        {
            return new(question);
        }
    }
}