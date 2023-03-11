using Application.Features.UrunFeatures.Commands.CreateUrun;
using Application.Features.UrunFeatures.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunController : ControllerBase
    {
        IMediator mediator;
        public UrunController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUrunCommand command)
        {
            var viewModel = await mediator.Send(command);
            return Ok(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllUrunQuery();
            var viewModel = await mediator.Send(query);
            return Ok(viewModel);
        }
    }
}
