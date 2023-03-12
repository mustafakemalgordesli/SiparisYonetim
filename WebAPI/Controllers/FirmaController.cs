using Application.Features.FirmaFeatures.Commands.CreateFirma;
using Application.Features.FirmaFeatures.Commands.UpdateFirma;
using Application.Features.FirmaFeatures.Queries.GetAll;
using Application.Features.FirmaFeatures.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmaController : ControllerBase
    {
        private readonly IMediator mediator;
        public FirmaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] CreateFirmaCommand command)
        {
            var viewModel = await mediator.Send(command);
            return Ok(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var viewModel = await mediator.Send(new GetAllFirmaQuery());
            return Ok(viewModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest(new { Success = false, Message = "Id cannot be null or zero" });
            }

            var query = new GetByIdQuery(id);
            var response = await mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute]int id, [FromBody]UpdateFirmaCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest(new { Success = false, Message = "Id does not match" });
            }

            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}
