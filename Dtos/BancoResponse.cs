using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Dtos
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }
        public string? FullName { get; set; }


    }
}