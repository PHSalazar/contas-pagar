using API_CONTAS_PAGAR.Data;
using API_CONTAS_PAGAR.Models;

namespace API_CONTAS_PAGAR.Repositories
{
    public class ContaRepository
    {
        private readonly ContasPagarDbContext _context;

        public ContaRepository(ContasPagarDbContext context)
        {
            _context = context;
        }

        public async Task<ContaModel> Create(ContaModel novaConta)
        {
            _context.Contas.Add(novaConta);
            await _context.SaveChangesAsync();

            return novaConta;
        }
    }
}
