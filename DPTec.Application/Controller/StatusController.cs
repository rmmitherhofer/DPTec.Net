using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class StatusController
    {
        private int _CodigoStatus;
        public StatusController(int codigoStatus)
        {
            _CodigoStatus = codigoStatus;
        }

        public List<StatusModel> GetStatus()
        {
            return StatusDAO.GetListaStatus(_CodigoStatus);
        }
    }
}