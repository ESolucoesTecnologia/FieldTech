using FieldTech.Application.Fornecedor.Dto;
using FieldTech.Application.Fornecedor.Handler.Command;
using FieldTech.Application.Fornecedor.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieldTech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        private readonly IMediator _mediator;

        public FornecedorController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Retorna toda a lista de fornecedores cadastrados
        /// </summary>
        /// <returns></returns>
        [Route("todos_fornecedores")]
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            return Ok(await _mediator.Send(new GetAllFornecedorQuery()));
        }

        [Route("criar_fornecedor")]
        [HttpPost]
        public async Task<IActionResult> Criar(FornecedorInputDto fornecedor)
        {
            var result = await _mediator.Send(new CreateFornecedorCommand(fornecedor));
            return Created($"{result.Fornecedor.Id}", result.Fornecedor);
        }




    }
}
