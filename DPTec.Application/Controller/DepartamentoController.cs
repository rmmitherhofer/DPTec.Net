using System;
using DPTec.Application.DAO;
using System.Linq;
using System.Web;
using DPTec.Application.Model;
using System.Collections.Generic;

namespace DPTec.Application.Controller
{
    public class DepartamentoController
    {
        private int _CodigoDepartamento;
        public DepartamentoController(int codigoDepartamento)
        {
            _CodigoDepartamento = codigoDepartamento;
        }
        public List<DepartamentoModel> GetDepartamento()
        {
            return DepartamentoDAO.GetDepartamentos(_CodigoDepartamento);
        }
    }
}