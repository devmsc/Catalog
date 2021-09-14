using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.Questions;
using MediatR;

namespace Catalog.Features.QuestionFeatures.GetQuestions
{
    public class GetQuestionsRequestHandler : IRequestHandler<GetQuestionsRequest, GetQuestionsResponse>
    {
        private IQuestionsRepository _questionsRepository;

        public GetQuestionsRequestHandler(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<GetQuestionsResponse> Handle(GetQuestionsRequest request, CancellationToken cancellationToken)
        {
            var questions = await _questionsRepository.GetAll();
            return await Task.FromResult(GetQuestionsResponse.GetSuccess(questions));
        }
    }
}