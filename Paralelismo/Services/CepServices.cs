using Paralelismo.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Paralelismo.Services
{
    public class CepServices
    {
        public CepModel ObterCep(string cep)
        {
            var client = new HttpClient();
            var response = client.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
            var conteudo = response.Content.ReadAsStringAsync().Result;
            var cepModel = JsonSerializer.Deserialize<CepModel>(conteudo);

            return cepModel;
        }
    }
}
