using System.Threading.Tasks;
using Catalog.Features.RequirementFeatures.AddRequirement;
using Catalog.Features.RequirementFeatures.GetRequirements;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequirementsController : ControllerBase
    {
        private IMediator _mediator;

        public RequirementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetRequirementsRequest()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddRequirementRequest request)
        {
            return Ok(await _mediator.Send(request));
        } 
    }
}