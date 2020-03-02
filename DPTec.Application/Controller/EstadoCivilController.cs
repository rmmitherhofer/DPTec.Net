using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class EstadoCivilController
    {
        private int _codigoEstadoCivil;
        public EstadoCivilController(int codigoEstadoCivil)
        {
            _codigoEstadoCivil = codigoEstadoCivil;                
        }

        public List<EstadoCivilModel> GetEstadoCivil()
        {
            return EstadoCivilDAO.GetEstadoCivil(_codigoEstadoCivil);
        }
    }
}