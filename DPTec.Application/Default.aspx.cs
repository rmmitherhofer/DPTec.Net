using DPTec.Application.Controller;
using DPTec.Application.Model;
using DPTec.Application.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DPTec.Application
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController usuario = new UsuarioController(txtLogin.Text, txtSenha.Value);
                var usuarios = usuario.Consultar();
                foreach (var u in usuarios)
                {
                    Session.Add("codigoUsuario", u.CodigoUsuario);
                    Session.Add("matricula", u.Matricula);
                }              
                Response.Redirect($"~/View/DefaultMaster.aspx", false);
            }
            catch(Exception ex)
            {
                messagealert.InnerHtml = ex.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);       
            }
        }
    }
}