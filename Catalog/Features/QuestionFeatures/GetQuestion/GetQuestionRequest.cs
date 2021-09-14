using System;
using System.Collections.Generic;
using System.Linq;
using MediatR;

namespace Catalog.Features.QuestionFeatures.GetQuestion
{
    public class GetQuestionRequest : IRequest<GetQuestionResponse>
    {
        public GetQuestionRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}