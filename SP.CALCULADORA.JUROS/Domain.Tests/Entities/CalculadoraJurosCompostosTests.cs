using Domain.Entities;
using FluentAssertions;
using Xunit;

namespace Domain.Tests.Entities
{
    /// <summary>
    /// Classes responsável pelos testes da entitade CalculadoraJurosCompostos
    /// </summary>
    public class CalculadoraJurosCompostosTests
    {
        [Fact]
        public void DadoValorInicial100EJuros1PorcentoE3MesesDeveRetornar103_03()
        {
            var valorInicial = 100.00m;
            var juros = 0.01m;
            var meses = 3;
            var calculadora = new CalculadoraJurosCompostos();

            var valorFinal = calculadora.Calcular(valorInicial, juros, meses);

            valorFinal.Should().Be(103.03m);
        }
    }
}
