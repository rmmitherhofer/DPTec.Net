using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class EmpresaModel
    {
        public int CodigoEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeRazaoSocial { get; set; }
        public long NumCNPJ { get; set; }
        public long NumInscricaoEstadual { get; set; }
        public string NomeSegmento { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public int StatusEmpresa { get; set; }
        public string NomeSite { get; set; }
        public string NumCEP { get; set; }
        public string NumLogradouro { get; set; }
        public string NomeComplemento { get; set; }
        public long NumTelefoneEmpresa { get; set; }
        public long NumTelefoneOuvidoria { get; set; }
        public string NomePais { get; set; }
    }
}