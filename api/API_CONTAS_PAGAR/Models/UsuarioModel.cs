using System.ComponentModel.DataAnnotations;

namespace API_CONTAS_PAGAR.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
