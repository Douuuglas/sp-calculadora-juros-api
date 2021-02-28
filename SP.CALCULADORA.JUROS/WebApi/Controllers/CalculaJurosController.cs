using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculadoraJurosCompostos _calculadora;

        public CalculaJurosController(CalculadoraJurosCompostos calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpPost]
        public decimal Post([FromBody] CalculaJurosGetRequest request)
        {
            return _calculadora.Calcular(request.ValorInicial, request.TaxaJuros, request.TempoEmMeses);
        }
    }
}
