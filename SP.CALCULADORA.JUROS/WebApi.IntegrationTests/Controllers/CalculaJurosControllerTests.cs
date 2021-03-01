using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApi.Dtos;
using Xunit;

namespace WebApi.IntegrationTests.Controllers
{
    public class CalculaJurosControllerTests
    {
        private readonly HttpClient _httpClient;

        public CalculaJurosControllerTests()
        {
            _httpClient = new WebApplicationFactory<Startup>().CreateClient();
        }

        [Fact]
        public async Task DadaRequiscaoGetValorInial100ETempo3DeveRetornar105_10()
        {
            var endpoint = "CalculaJuros";
            var request = new CalculaJurosCompostosDto() { ValorInicial = 100, TempoEmMeses = 5  };
            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(endpoint, content);
            var result = Convert.ToDecimal(await response.Content.ReadAsStringAsync());

            response.StatusCode.Should().Be(200);
            result.Should().Be(105.10m);
        }
    }
}
