using Application.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly CalculadoraJurosCompostosService _calculadora;

        public CalculaJurosController(CalculadoraJurosCompostosService calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpPost]
        public async Task<decimal> Post([FromBody] CalculaJurosCompostosDto request)
        {
            return await _calculadora.Calcular(request);
        }
    }
}
