using System;
using System.Threading.Tasks;
using Catalog.Features.QuestionFeatures.AddQuestion;
using Catalog.Features.QuestionFeatures.DeleteQuestion;
using Catalog.Features.QuestionFeatures.GetQuestion;
using Catalog.Features.QuestionFeatures.GetQuestions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : ControllerBase
    {
        private IMediator _mediator;

        public QuestionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetQuestionsRequest()));
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AddQuestionRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetQuestionRequest(id)));
        }
            
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteQuestionRequest(id)));
        }
    }
}