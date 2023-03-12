using Application.Features.SiparisFeatures.Commands.CreateSiparis;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        IMediator mediator;

        public SiparisController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateSiparisCommand command) 
        {
            var viewModel = await mediator.Send(command);
            return Ok(viewModel);
        }
    }
}
