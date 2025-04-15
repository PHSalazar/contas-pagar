using System.ComponentModel.DataAnnotations;

namespace API_CONTAS_PAGAR.Models
{
    public class ContaModel
    {
        [Key]
        public int IdConta { get; set; }
        public int IdUsuario { get; set; }
        public string Tituloconta { get; set; }
        public int VencConta { get; set; }
        public decimal ValorConta { get; set; }
        public bool ContaPaga { get; set; }
    }
}
