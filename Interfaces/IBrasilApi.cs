using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {

        Task<ResponseGeneric<EnderecoModel>> BuscaEnderecoPorCEP(string cep);
        Task<ResponseGeneric<List<BancoModel>>> BuscaTodosBancos();
        Task<ResponseGeneric<BancoModel>> BuscaBanco(string codigoBanco);




    }
}