namespace API_CONTAS_PAGAR.Models
{
    public class ContaRequestModel
    {
        public int IdUsuario { get; set; }
        public string Tituloconta { get; set; }
        public int VencConta { get; set; }
        public decimal ValorConta { get; set; }
        public bool ContaPaga { get; set; }
    }
}
