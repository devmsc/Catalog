using System.Collections.Generic;
using System.Linq;
using Catalog.Models.DTO;
using Catalog.Models.Requirements;
using Catalog.Models.Responses;

namespace Catalog.Features.ComplianceProcessesFeatures.GetComplianceProcesses
{
    public class GetComplianceProcessesResponse : ResponseBaseModel<List<ComplianceProcessDto>>
    {
        public static GetComplianceProcessesResponse GetSuccess(List<ComplianceProcess> complianceProcesses) =>
            new GetComplianceProcessesResponse()
            {
                Data = ConvertToDto(complianceProcesses),
                Message = "Комплаенс-процедуры получены",
                ResponseStatus = ResponseStatus.Success
            };

        public static List<ComplianceProcessDto> ConvertToDto(List<ComplianceProcess> complianceProcesses)
        {
            return complianceProcesses.Select(item => new ComplianceProcessDto(item)).ToList();
        }
    }
}