using System;
using Catalog.Models.Responses;

namespace Catalog.Features.RelationStagesFeatures.AddRelationStage
{
    public class AddRelationStageResponse : ResponseBaseModel<Guid>
    {
        public static AddRelationStageResponse GetSuccess(Guid id) =>
            new AddRelationStageResponse()
            {
                Data = id,
                Message = "Этап взаимоотношений с клиентом получен",
                ResponseStatus = ResponseStatus.Success
            };
    }
}