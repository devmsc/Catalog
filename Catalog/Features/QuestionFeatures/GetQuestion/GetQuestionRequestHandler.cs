using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.Questions;
using MediatR;

namespace Catalog.Features.QuestionFeatures.GetQuestion
{
    public class GetQuestionRequestHandler : IRequestHandler<GetQuestionRequest, GetQuestionResponse>
    {
        private IQuestionsRepository _questionsRepository;

        public GetQuestionRequestHandler(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<GetQuestionResponse> Handle(GetQuestionRequest request, CancellationToken cancellationToken)
        {
            var question = await _questionsRepository.GetWithTriggers(request.Id);
            return await Task.FromResult(GetQuestionResponse.GetSuccess(question));
        }
    }
}