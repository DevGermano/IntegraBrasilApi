using System.Dynamic;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}