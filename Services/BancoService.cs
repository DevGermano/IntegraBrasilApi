using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscaTodosBancos();
            return _mapper.Map<ResponseGeneric<List<BancoResponse>>>(bancos);
        }

        public async Task<ResponseGeneric<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscaBanco(codigoBanco);
            return _mapper.Map<ResponseGeneric<BancoResponse>>(banco);
        }
    }
}