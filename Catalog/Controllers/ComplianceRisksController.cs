using System;
using System.Threading.Tasks;
using Catalog.Features.ComplianceRisksFeatures.AddComplianceRisk;
using Catalog.Features.ComplianceRisksFeatures.GetComplianceRisks;
using Catalog.Features.RelationStagesFeatures.AddRelationStage;
using Catalog.Features.RelationStagesFeatures.GetRelationStages;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplianceRisksController : ControllerBase
    {
        private IMediator _mediator;

        public ComplianceRisksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetComplianceRisksRequest()));
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AddComplianceRiskRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok();
        }
            
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok();
        }
    }
}