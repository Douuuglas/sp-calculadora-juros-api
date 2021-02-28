using System;

namespace Domain.Entities
{
    /// <summary>
    ///  Classe responsável por calcular os juros compostos
    ///  de acordo com determinados dados de entrada
    /// </summary>
    public class CalculadoraJurosCompostos
    {
        public decimal Calcular(decimal valorInicial, decimal taxaJuros, int tempoEmMeses)
        {
            var juros = (decimal)Math.Pow(1 + (double)taxaJuros, tempoEmMeses);
            return Math.Round(valorInicial * juros, 2);
        }
    }
}
