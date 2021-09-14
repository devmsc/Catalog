using System.Threading;
using System.Threading.Tasks;
using Catalog.Repositories.RelationStages;
using MediatR;

namespace Catalog.Features.RelationStagesFeatures.GetRelationStages
{
    public class GetRelationStagesRequestHandler : IRequestHandler<GetRelationStagesRequest, GetRelationStagesResponse>
    {
        private IRelationStagesRepository _relationStagesRepository;

        public GetRelationStagesRequestHandler(IRelationStagesRepository relationStagesRepository)
        {
            _relationStagesRepository = relationStagesRepository;
        }

        public async Task<GetRelationStagesResponse> Handle(GetRelationStagesRequest request, CancellationToken cancellationToken)
        {
            var relationStages = await _relationStagesRepository.GetAll();
            return await Task.FromResult(GetRelationStagesResponse.GetSuccess(relationStages));
        }
    }
}