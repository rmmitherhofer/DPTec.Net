using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class FinancasController
    {
        private int _CodigoBanco;
        private int _Matricula;
        public FinancasController(int codigoBanco, int matricula)
        {
            _CodigoBanco = codigoBanco;
            _Matricula = matricula;
        }
        public List<BancoModel> GetBanco()
        {
            return FincancasDAO.GetBanco(_CodigoBanco);
        }
        public List<FinancaModel> GetFinancas()
        {
            return FincancasDAO.GetFinancas(_Matricula);
        }
    }
}