using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class EnderecoController
    {
        private string _CEP;
        public EnderecoController(string CEP)
        {
            _CEP = CEP;
        }
        public List<EnderecoModel> BuscarEndereco()
        {
            EnderecoModel enderecoModel = new EnderecoModel(_CEP);
            return EnderecoDAO.GetEnderecos(enderecoModel);
        }
    }
}