using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Requirements;
using Catalog.Repositories.RelationStages;
using MediatR;

namespace Catalog.Features.RelationStagesFeatures.AddRelationStage
{
    public class AddRelationStageRequestHandler : IRequestHandler<AddRelationStageRequest, AddRelationStageResponse>
    {
        private IRelationStagesRepository _relationStagesRepository;

        public AddRelationStageRequestHandler(IRelationStagesRepository relationStagesRepository)
        {
            _relationStagesRepository = relationStagesRepository;
        }

        public async Task<AddRelationStageResponse> Handle(AddRelationStageRequest request, CancellationToken cancellationToken)
        {
            var relationStage = new RelationStage(request.Content);
            var relationStageId = await _relationStagesRepository.Insert(relationStage, cancellationToken);
            return await Task.FromResult(AddRelationStageResponse.GetSuccess(relationStageId));
        }
    }
}