using Application.Interfaces;
using Domain.Entities;
using System.Threading.Tasks;
using WebApi.Dtos;

namespace Application.Service
{
    public class CalculadoraJurosCompostosService
    {
        private readonly CalculadoraJurosCompostos _calculadora;
        private readonly ITaxaJurosRepository _taxaJurosRepository;

        public CalculadoraJurosCompostosService(CalculadoraJurosCompostos calculadora, ITaxaJurosRepository taxaJurosRepository)
        {
            _calculadora = calculadora;
            _taxaJurosRepository = taxaJurosRepository;
        }

        public async Task<decimal> Calcular(CalculaJurosCompostosDto request)
        {
            var taxaJuros = await _taxaJurosRepository.BuscarTaxaJuros();
            return _calculadora.Calcular(request.ValorInicial, taxaJuros, request.TempoEmMeses);
        }
    }
}
