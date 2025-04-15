using API_CONTAS_PAGAR.Models;
using API_CONTAS_PAGAR.Repositories;

namespace API_CONTAS_PAGAR.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<UsuarioModel> Create(UsuarioModel novoUsuario)
        {
            await _repository.Create(novoUsuario);
            return novoUsuario;
        }
    }
}
