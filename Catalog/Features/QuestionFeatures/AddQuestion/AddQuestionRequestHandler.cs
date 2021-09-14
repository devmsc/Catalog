using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Questions;
using Catalog.Repositories.Questions;
using MediatR;

namespace Catalog.Features.QuestionFeatures.AddQuestion
{
    public class AddQuestionRequestHandler : IRequestHandler<AddQuestionRequest, AddQuestionResponse>
    {
        private IQuestionsRepository _questionsRepository;

        public AddQuestionRequestHandler(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<AddQuestionResponse> Handle(AddQuestionRequest request, CancellationToken cancellationToken)
        {
            var triggers = request.Triggers.Select(item => new Trigger(item)).ToList();
            var questionId = await _questionsRepository.Insert(new Question(request.Content, request.QuestionType, triggers), cancellationToken);
            return await Task.FromResult(AddQuestionResponse.GetSuccess(questionId));
        }
    }
}