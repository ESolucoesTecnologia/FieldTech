using FieldTech.Application.Field.Dto;
using FieldTech.Application.Field.Handler.Command;
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

        /// <summary>
        /// Retorna toda a lista de técnicos cadastrados
        /// </summary>
        /// <returns></returns>
        [Route("todos_tecnicos")]
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            return Ok(await _mediator.Send(new GetAllTecnicoQuery()));
        }

        /// <summary>
        /// Cria um técnico
        /// </summary>
        /// <param name="tecnico"></param>
        /// <returns></returns>
        [Route("criar_tecnico")]
        [HttpPost]
        public async Task<IActionResult> Criar(TecnicoInputDto tecnico)
        {
            var result = await _mediator.Send(new CreateTecnicoCommand(tecnico));
            return Created($"{result.Tecnico.Id}", result.Tecnico);            
        }


    }
}
