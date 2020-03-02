using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class EmpresaController
    {
        private int _CodigoEmpresa;
        public EmpresaController(int codigoEmpresa)
        {
            _CodigoEmpresa = codigoEmpresa;
        }

        public List<EmpresaModel> GetEmpresa()
        {
            return EmpresaDAO.GetEmpresas(_CodigoEmpresa);
        }
    }
}