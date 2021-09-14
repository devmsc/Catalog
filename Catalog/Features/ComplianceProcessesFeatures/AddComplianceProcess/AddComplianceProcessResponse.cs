using System;
using Catalog.Models.Responses;

namespace Catalog.Features.ComplianceProcessesFeatures.AddComplianceProcess
{
    public class AddComplianceProcessResponse : ResponseBaseModel<Guid>
    {
        public static AddComplianceProcessResponse GetSuccess(Guid id) =>
            new AddComplianceProcessResponse()
            {
                Data = id,
                Message = "Комплаенс-процедура добавлена в базу данных",
                ResponseStatus = ResponseStatus.Success
            };
    }
}