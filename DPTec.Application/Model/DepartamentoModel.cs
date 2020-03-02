using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class DepartamentoModel
    {
        public int CodigoDepartamento { get; set; }
        public string DescricaoDepartamento { get; set; }
        public string CentroCusto { get; set; }
        public int MatriculaImediato { get; set; }
    }
}