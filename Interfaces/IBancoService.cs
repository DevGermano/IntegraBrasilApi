using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGeneric<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGeneric<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}