using System.Collections.Generic;
using Catalog.Models.Requirements;
using Catalog.Models.Responses;

namespace Catalog.Features.RequirementFeatures.GetRequirements
{
    public class GetRequirementsResponse : ResponseBaseModel<List<Requirement>>
    {
        public static GetRequirementsResponse GetSuccess(List<Requirement> requirements) =>
            new GetRequirementsResponse()
            {
                Data = requirements,
                Message = "Требования получены",
                ResponseStatus = ResponseStatus.Success
            };
    }
}