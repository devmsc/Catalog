using System;
using Catalog.Models.Responses;

namespace Catalog.Features.ComplianceRisksFeatures.AddComplianceRisk
{
    public class AddComplianceRiskResponse : ResponseBaseModel<Guid>
    {
        public static AddComplianceRiskResponse GetSuccess(Guid id) =>
            new AddComplianceRiskResponse()
            {
                Data = id,
                Message = "Комплаенс-риск добавлен в базу данных",
                ResponseStatus = ResponseStatus.Success
            };
    }
}