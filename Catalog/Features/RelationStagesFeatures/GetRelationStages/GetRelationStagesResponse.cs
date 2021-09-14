using System.Collections.Generic;
using System.Linq;
using Catalog.Models.DTO;
using Catalog.Models.Requirements;
using Catalog.Models.Responses;

namespace Catalog.Features.RelationStagesFeatures.GetRelationStages
{
    public class GetRelationStagesResponse : ResponseBaseModel<List<RelationStageDto>>
    {
        public static GetRelationStagesResponse GetSuccess(List<RelationStage> relationStages) =>
            new GetRelationStagesResponse()
            {
                Data = ConvertToDto(relationStages),
                Message = "Этапы взаимоотношений с клиентом получены",
                ResponseStatus = ResponseStatus.Success
            };

        private static List<RelationStageDto> ConvertToDto(List<RelationStage> relationStages)
        {
            return relationStages.Select(item => new RelationStageDto(item)).ToList();
        }
    }
}