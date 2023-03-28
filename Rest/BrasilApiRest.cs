using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGeneric<EnderecoModel>> BuscaEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGeneric<EnderecoModel>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
        public Task<ResponseGeneric<BancoModel>> BuscaBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }
        public Task<ResponseGeneric<List<BancoModel>>> BuscaTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}