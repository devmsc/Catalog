using System;
using MediatR;

namespace Catalog.Features.QuestionFeatures.DeleteQuestion
{
    public class DeleteQuestionRequest : IRequest<DeleteQuestionResponse>
    {
        public DeleteQuestionRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}