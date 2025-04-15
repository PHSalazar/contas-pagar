using API_CONTAS_PAGAR.Data;
using API_CONTAS_PAGAR.Models;

namespace API_CONTAS_PAGAR.Repositories
{
    public class UsuarioRepository
    {
        private readonly ContasPagarDbContext _context;

        public UsuarioRepository(ContasPagarDbContext context)
        {
            _context = context;
        }

        public async Task<UsuarioModel> Create(UsuarioModel novoUsuario)
        {
            _context.Usuarios.Add(novoUsuario);
            await _context.SaveChangesAsync();
            return novoUsuario;
        }
    }
}
