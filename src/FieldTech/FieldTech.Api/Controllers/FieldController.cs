using FieldTech.Application.Field.Handler.Query;
using FieldTech.Application.Field.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieldTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldController : ControllerBase
    {
        private readonly IMediator _mediator;


        public FieldController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Route("get_all")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllTecnicoQuery()));
        }


    }
}
