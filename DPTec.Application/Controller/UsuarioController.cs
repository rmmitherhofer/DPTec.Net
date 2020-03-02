using DPTec.Application.DAO;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DPTec.Application.Controller
{
    public class UsuarioController
    {
        private readonly string _login;
        private readonly string _senha;
        private readonly int _codigoUsuario;

        #region Construtores
        /// <summary>
        /// Construtor para Validação de Acesso
        /// </summary>
        /// <param name="login">Faz Referencia com <see cref="_Login"/> e o <paramref name="login"/> é Obrigatório</param>
        /// <param name="senha">Faz Referencia Com <see cref="_Senha"/>e o <paramref name="senha"/> é Obrigatório</param>
        public UsuarioController(string login, string senha)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new NullReferenceException("Necesário Informar Login de Acesso.");
            }
            if (string.IsNullOrEmpty(senha))
            {
                throw new NullReferenceException("Necesário Informar Senha de Acesso.");
            }

            this._login = login;
            this._senha = senha;
        }
        public UsuarioController(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new NullReferenceException("Necesário Informar Login de Acesso.");
            }
            this._login = login;
        }
        public UsuarioController(int codigoUsuario)
        {
            if (codigoUsuario <= 0)
            {
                throw new NullReferenceException("Usuário não Autenticado");
            }
            this._codigoUsuario = codigoUsuario;
        }
        #endregion       

        /// <summary>
        /// Busca Informações Do Usuario
        /// </summary>
        public List<UsuarioModel> Consultar()
        {
            UsuarioModel usuarioModel = new UsuarioModel(_login);
            var retorno = UsuarioDAO.GetListaUsuario(usuarioModel);

            if (retorno.Any())
            {
                Autenticar(retorno);
                return retorno;
            }
            else
            {
                throw new Exception("Usuario não encontrado.");
            }
        }

        /// <summary>
        /// Valida Informações Do Usuario Encontrado
        /// </summary>
        /// <param name="usuarios">Objeto <paramref name="usuarios"/> faz referencia com Classe <see cref="UsuarioModel"/></param>
        private void Autenticar(List<UsuarioModel> usuarios)
        {
            string Senha = null;
            string Login = null;
            bool Ativo = false;
            foreach (var u in usuarios)
            {
                Senha = u.Senha;
                Login = u.Login;
                Ativo = u.Ativo;

                PerfilController perfil = new PerfilController(u.CodigoUsuario);
                perfil.ConsultarPerfil();
            }

            if (!Senha.Equals(_senha))
            {
                throw new Exception("Senha Inválida.");
            }
            if (Ativo == false)
            {
                throw new Exception("Conta Inativa, Contate o Administrador.");
            }
        }
    }
}