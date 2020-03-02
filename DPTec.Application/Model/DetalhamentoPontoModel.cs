using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class DetalhamentoPontoModel : PontoModel
    {
        public int CodigoDetalhamentoPonto { get; set; }        
        public DateTime Data { get; set; }
        public string Semana { get; set; }
        public int CodigoSemana { get; set; }
        public byte Abono { get; set; }
        public byte DebitoBanco { get; set; }
        public byte DebitoSalario { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaidaAlmoco { get; set; }
        public string HoraVoltaAlmoco { get; set; }
        public string HoraSaida { get; set; }
        public string Observacao { get; set; }
        public string HoraEntradaPadrao { get; set; }
        public string HoraSaidaAlmocoPadrao { get; set; }
        public string HoraVoltaAlmocoPadrao { get; set; }
        public string HoraSaidaPadrao { get; set; }
        public string HoraAlmoco { get; set; }
        public string HoraAdicional { get; set; }

        public DetalhamentoPontoModel(int mes, int ano, int matricula, int ponto)
        {
            Matricula = matricula;
            Mes = mes;
            Ano = ano;
            CodigoPonto = ponto;
        }

        public DetalhamentoPontoModel()
        {
        }
    }
}