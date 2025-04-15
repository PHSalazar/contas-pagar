using API_CONTAS_PAGAR.Models;
using API_CONTAS_PAGAR.Repositories;

namespace API_CONTAS_PAGAR.Services
{
    public class ContaService
    {
        private readonly ContaRepository _repository;

        public ContaService(ContaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ContaModel>> GetByUserId(int userId)
        {
            return await _repository.GetByUserId(userId);
        }

        public async Task<ContaModel> Create(ContaModel contaModel)
        {
            return await _repository.Create(contaModel);
        }
    }
}
