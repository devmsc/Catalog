using System;
using System.Threading.Tasks;
using Catalog.Features.ComplianceProcessesFeatures.AddComplianceProcess;
using Catalog.Features.ComplianceProcessesFeatures.GetComplianceProcesses;
using Catalog.Features.ComplianceRisksFeatures.AddComplianceRisk;
using Catalog.Features.ComplianceRisksFeatures.GetComplianceRisks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplianceProcessesController : ControllerBase
    {
        private IMediator _mediator;

        public ComplianceProcessesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetComplianceProcessesRequest()));
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AddComplianceProcessRequest request)
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