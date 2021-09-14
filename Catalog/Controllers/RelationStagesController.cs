using System;
using System.Threading.Tasks;
using Catalog.Features.QuestionFeatures.AddQuestion;
using Catalog.Features.QuestionFeatures.DeleteQuestion;
using Catalog.Features.QuestionFeatures.GetQuestion;
using Catalog.Features.QuestionFeatures.GetQuestions;
using Catalog.Features.RelationStagesFeatures.AddRelationStage;
using Catalog.Features.RelationStagesFeatures.GetRelationStages;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RelationStagesController : ControllerBase
    {
        private IMediator _mediator;

        public RelationStagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetRelationStagesRequest()));
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AddRelationStageRequest request)
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