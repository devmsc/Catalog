using System;
using Catalog.Models.Responses;

namespace Catalog.Features.QuestionFeatures.DeleteQuestion
{
    public class DeleteQuestionResponse : ResponseBaseModel<Guid>
    {
        public static DeleteQuestionResponse GetSuccess(Guid id) =>
            new DeleteQuestionResponse()
            {
                Data = id,
                Message = $"Вопрос с {id} удален",
                ResponseStatus = ResponseStatus.Success
            };
    }
}