using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.Questions;
using MediatR;

namespace Catalog.Features.QuestionFeatures.DeleteQuestion
{
    public class DeleteQuestionRequestHandler : IRequestHandler<DeleteQuestionRequest, DeleteQuestionResponse>
    {
        private IQuestionsRepository _questionsRepository;

        public DeleteQuestionRequestHandler(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public async Task<DeleteQuestionResponse> Handle(DeleteQuestionRequest request, CancellationToken cancellationToken)
        {
            await _questionsRepository.Delete(request.Id, cancellationToken);
            return await Task.FromResult(DeleteQuestionResponse.GetSuccess(request.Id));
        }
    }
}