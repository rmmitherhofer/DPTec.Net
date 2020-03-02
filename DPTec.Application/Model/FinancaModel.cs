using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class FinancaModel : FuncionarioModel
    {
        public int CodigoFinanca { get; set; }
        public string TipoConta { get; set; }
        public int CodigoBanco { get; set; }
        public int Agencia { get; set; }
        public long Conta { get; set; }
        public int Digito { get; set; }
        public int StatusConta { get; set; }
        public double ValorSalarial { get; set; }
    }
}