using System;
using Catalog.Models.Responses;

namespace Catalog.Features.RequirementFeatures.AddRequirement
{
    public class AddRequirementResponse : ResponseBaseModel<Guid>
    {
        public static AddRequirementResponse GetSuccess(Guid requirement) =>
            new AddRequirementResponse()
            {
                Data = requirement,
                Message = "Требование создано",
                ResponseStatus = ResponseStatus.Success
            };
    }
}