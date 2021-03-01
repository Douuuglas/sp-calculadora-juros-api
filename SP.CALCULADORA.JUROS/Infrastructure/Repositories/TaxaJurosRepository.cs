using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TaxaJurosRepository : ITaxaJurosRepository
    {
        private readonly HttpClient _httpClient;

        public TaxaJurosRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(configuration["TaxaJurosBaseUrl"]);
        }

        public async Task<decimal> BuscarTaxaJuros()
        {
            var responseString = await _httpClient.GetStringAsync("TaxaJuros");
            var juros = JsonConvert.DeserializeObject<decimal>(responseString);
            
            return juros;
        }
    }
}
