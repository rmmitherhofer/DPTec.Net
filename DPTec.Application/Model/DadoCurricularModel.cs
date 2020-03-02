using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class DadoCurricularModel
    {
        public int cdCurricular { get; set; }
        public int cdCategoria { get; set; }
        public string nmLocal { get; set; }
        public string dsCurriculo { get; set; }
        public DateTime inicio { get; set; }
        public DateTime conclusao { get; set; }
        public int cdStatus { get; set; }
    }
}