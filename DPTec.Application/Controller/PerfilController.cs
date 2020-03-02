using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Controller
{
    public class PerfilController
    {
        private int _codigoUsuario;
        private readonly int _modulo;
        public PerfilController(int codigoUsuario)
        {
            _codigoUsuario = codigoUsuario;
        }
        public PerfilController(int codigoUsuario, int modulo)
        {
            _codigoUsuario = codigoUsuario;
            _modulo = modulo;
        }

        public bool ConsultarPerfil()
        {
            PerfilModel perfilModel = new PerfilModel(_codigoUsuario);
            var retorno = PerfilDAO.GetListaPerfil(perfilModel);
            if (retorno.Any())
            {
                return ValidarPerfil(retorno, _modulo);                
            }
            else
            {
                throw new Exception("Você não Possui Perfis de Acesso. \n Contate a Administração do Sistema");
            }
        }

        private bool ValidarPerfil(List<PerfilModel> perfil, int modulo)
        {
            foreach (var p in perfil)
            {
                if (p.CodigoPerfil == modulo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}