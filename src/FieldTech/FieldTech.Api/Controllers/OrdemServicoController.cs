using FieldTech.Application.OrdemServico.Dto;
using FieldTech.Application.OrdemServico.Handler.Command;
using FieldTech.Application.OrdemServico.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FieldTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {

        private readonly IMediator _mediator;

        public OrdemServicoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Route("todas_ordens")]
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            return Ok(await _mediator.Send(new GetAllOrdemQuery()));
        }

        [Route("criar_ordem")]
        [HttpPost]
        public async Task<IActionResult> Criar(OrdemInputDto ordem)
        {
            var result = await _mediator.Send(new CreateOrdemCommand(ordem));
            return Created($"{result.Ordem.Id}", result.Ordem);

        }

        [Route("obter_por_id")]
        [HttpGet]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var result = await _mediator.Send(new GetIdOrdemQuery(id));
            return Ok(result);  
        }



    }
}
