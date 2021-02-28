namespace WebApi.Dtos
{
    public class CalculaJurosGetRequest
    {
        public decimal ValorInicial { get; set; }
        public decimal TaxaJuros { get; set; }
        public int TempoEmMeses { get; set; }
    }
}
