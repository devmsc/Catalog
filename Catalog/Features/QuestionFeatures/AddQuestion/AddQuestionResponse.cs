using System;
using Catalog.Models.Responses;

namespace Catalog.Features.QuestionFeatures.AddQuestion
{
    public class AddQuestionResponse : ResponseBaseModel<Guid>
    {
        public static AddQuestionResponse GetSuccess(Guid questionId) =>
            new AddQuestionResponse()
            {
                Data = questionId,
                Message = "Вопрос добавлен",
                ResponseStatus = ResponseStatus.Success
            };
    }
}