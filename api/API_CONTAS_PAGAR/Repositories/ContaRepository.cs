using API_CONTAS_PAGAR.Data;
using API_CONTAS_PAGAR.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CONTAS_PAGAR.Repositories
{
    public class ContaRepository
    {
        private readonly ContasPagarDbContext _context;

        public ContaRepository(ContasPagarDbContext context)
        {
            _context = context;
        }

        public async Task<List<ContaModel>> GetByUserId(int userId)
        {
            var contasEncontrada = await _context.Contas.Where(c => c.IdUsuario == userId).ToListAsync();

            if (contasEncontrada.Count == 0)
            {
                return null;
            }

            return contasEncontrada;
        }

        public async Task<ContaModel> Create(ContaModel novaConta)
        {
            _context.Contas.Add(novaConta);
            await _context.SaveChangesAsync();

            return novaConta;
        }
    }
}
