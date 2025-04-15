using API_CONTAS_PAGAR.Models;
using API_CONTAS_PAGAR.Repositories;
using API_CONTAS_PAGAR.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CONTAS_PAGAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly ContaService _service;
        private readonly IMapper _mapper;

        public ContasController(ContaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{userId:int}")]
        public async Task<ActionResult<List<ContaModel>>> GetByUserId([FromRoute] int userId)
        {
            var contasUsuario = await _service.GetByUserId(userId);
            if (contasUsuario == null)
            {
                return NotFound($"Nenhum usuário encontrado com o id {userId}.");
            }

            return Ok(contasUsuario);
        }

        [HttpGet("{userId:int}/pendentes")]
        public async Task<ActionResult<List<ContaModel>>> GetPendingByUser([FromRoute] int userId)
        {
            var contasUsuario = await _service.GetByUserId(userId);
            if (contasUsuario == null)
            {
                return NotFound($"Nenhum usuário encontrado com o id {userId}.");
            }

            var contasPendentesUsuario = await _service.GetPendingByUser(userId);
            if (contasPendentesUsuario == null)
            {
                return NotFound($"Usuário {userId} nao tem faturas em aberto.");
            }

            return Ok(contasPendentesUsuario);
        }

        [HttpPost]
        public async Task<ActionResult<ContaModel>> Create([FromBody] ContaRequestModel novaContaRequest)
        {
            var novaConta = _mapper.Map<ContaModel>(novaContaRequest);
            await _service.Create(novaConta);
            return Ok(novaConta);
        }
    }
}
