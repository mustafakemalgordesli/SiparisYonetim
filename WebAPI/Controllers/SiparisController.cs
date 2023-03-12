using Application.Features.SiparisFeatures.Commands.CreateSiparis;
using Application.Features.SiparisFeatures.Queries.GetAllByFirma;
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

        [HttpGet("byfirma/{id}")]
        public async Task<IActionResult> GetAllSiparisByFirma(int id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest(new { Success = false, Message = "Id cannot be null or zero" });
            }

            var query = new GetAllByFirmaQuery(id);
            var viewModel = await mediator.Send(query);
            return Ok(viewModel);
        }
    }
}
