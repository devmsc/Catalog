using MediatR;

namespace Catalog.Features.RelationStagesFeatures.AddRelationStage
{
    public class AddRelationStageRequest : IRequest<AddRelationStageResponse>
    {
        public string Content { get; set; }
    }
}