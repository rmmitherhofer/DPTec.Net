using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DPTec.Application.Model
{
    public class UsuarioModel
    {
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Matricula { get; set; }
        public bool Ativo { get; set; }

        public UsuarioModel(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
        public UsuarioModel(string login)
        {
            Login = login;
        }
        public UsuarioModel(int codigoUsuario)
        {
            CodigoUsuario = codigoUsuario;
        }
        public UsuarioModel()
        {
        }
    }
}