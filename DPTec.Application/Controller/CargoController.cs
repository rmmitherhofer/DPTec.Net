using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class CargoController
    {
        private int _CodigoCargo;
        public CargoController(int codigoStatus)
        {
            _CodigoCargo = codigoStatus;
        }

        public List<CargoModel> GetCargo()
        {
            return CargoDAO.GetCargo(_CodigoCargo);
        }
    }
}