using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class EnderecoModel
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }

        public EnderecoModel(string CEP)
        {
           this.CEP = CEP;
        }
        public EnderecoModel()
        {
        }
    }
}