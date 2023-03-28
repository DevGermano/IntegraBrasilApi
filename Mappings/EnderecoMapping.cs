using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}