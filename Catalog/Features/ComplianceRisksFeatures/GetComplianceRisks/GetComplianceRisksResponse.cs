using System.Collections.Generic;
using System.Linq;
using Catalog.Models.DTO;
using Catalog.Models.Requirements;
using Catalog.Models.Responses;

namespace Catalog.Features.ComplianceRisksFeatures.GetComplianceRisks
{
    public class GetComplianceRisksResponse : ResponseBaseModel<List<ComplianceRiskDto>>
    {
        public static GetComplianceRisksResponse GetSuccess(List<ComplianceRisk> complianceRisks) =>
            new GetComplianceRisksResponse()
            {
                Data = ConvertToDto(complianceRisks),
                Message = "Комплаенс-риски получены",
                ResponseStatus = ResponseStatus.Success
            };

        private static List<ComplianceRiskDto> ConvertToDto(List<ComplianceRisk> complianceRisks)
        {
            return complianceRisks.Select(item => new ComplianceRiskDto(item)).ToList();
        }
    }
}