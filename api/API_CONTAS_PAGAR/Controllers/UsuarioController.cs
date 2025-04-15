using API_CONTAS_PAGAR.Models;
using API_CONTAS_PAGAR.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CONTAS_PAGAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;
        private readonly IMapper _mapper;

        public UsuarioController(UsuarioService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Create([FromBody] UsuarioRequestModel novoUsuarioRequest)
        {
            var novoUsuario = _mapper.Map<UsuarioModel>(novoUsuarioRequest);
            await _service.Create(novoUsuario);
            return Ok(novoUsuario);
        }
    }
}
