using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class PontoModel : FuncionarioModel
    {
        public int CodigoPonto { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime DataPeriodoInicio { get; set; }
        public DateTime DataPeriodoFim { get; set; }
        public string StatusPonto { get; set; }
        public string SaldoReferencia { get; set; }
        public string Saldo { get; set; }
        public string Competencia { get; set; }

        public PontoModel()
        {
        }
        public PontoModel(int mes, int ano, int matricula)
        {
            Matricula = matricula;
            Mes = mes;
            Ano = ano;
        }
    }
}