using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class PerfilModel : UsuarioModel
    {
        public int CodigoPerfil { get; set; }
        public string TipoPerfil { get; set; }
        public string DescLiberacao { get; set; }
        public string DescSistema { get; set; }

        public PerfilModel(int codigoUsuario)
        {
            CodigoUsuario = codigoUsuario;
        }
        public PerfilModel() { }
    }
}