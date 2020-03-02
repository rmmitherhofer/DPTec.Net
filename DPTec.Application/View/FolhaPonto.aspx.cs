using DPTec.Application.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Humanizer;

namespace DPTec.Application.View
{
    public partial class FolhaPonto : System.Web.UI.Page
    {
        private int _codigoUsuario;
        private int _matricula;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _codigoUsuario = Convert.ToInt32(Session["codigoUsuario"]);
                _matricula = Convert.ToInt32(Session["matricula"]);

                if (_codigoUsuario > 0)
                {
                    if (!this.IsPostBack)
                    {
                        dplAno.Text = DateTime.Now.Year.ToString();
                        dplMes.Text = DateTime.Now.Month.ToString();
                        GetFuncionario();
                        GetPonto();
                    }
                }
                else
                {
                    messagealert.InnerHtml = "Usuario Não Autenticado";
                    ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
                    Response.Redirect($"~/Default.aspx", false);
                }
            }
            catch (Exception ex)
            {
                messagealert.InnerHtml = ex.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
        }
        protected void dplMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFuncionario();
            GetPonto();
        }
        protected void btnMarcarPonto_Click(object sender, EventArgs e)
        {
                dplAno.Text = DateTime.Now.Year.ToString();
                dplMes.Text = DateTime.Now.Month.ToString();
                MarcarPonto();
        }
        protected void GetFuncionario()
        {
            try
            {
                PerfilController perfil = new PerfilController(_codigoUsuario, 2);
                bool retorno = perfil.ConsultarPerfil();
                if (retorno)
                {
                    FuncionarioController funcionarioController = new FuncionarioController(_matricula);
                    var funcionarios = funcionarioController.Consultar();
                    foreach (var f in funcionarios)
                    {
                        lblNome.Text = f.NomeFuncionario;
                        lblMatricula.Text = f.Matricula.ToString();
                        lblCPF.Text = f.NumCPF.ToString();
                    }
                }
            }catch (Exception e)
            {
                messagealert.InnerHtml = e.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
        }
        protected void GetPonto()
        {
            try
            {
                PontoController pontoController = new PontoController(int.Parse(dplAno.Text), int.Parse(dplMes.Text), _matricula);
                var ponto = pontoController.ListaPonto();

                foreach (var p in ponto)
                {
                    lblCompetencia.Text = p.Competencia;
                    lblSaldoH.Text = p.Saldo;
                    lblStatus.Text = p.StatusPonto.ToString();
                }

                string data = null;
                string dia = null;
                string horario = null;
                string marcacao = null;
                string saldo = null;
                foreach (var p in ponto)
                {
                    data += $"<label>{p.Data.ToString("dd/MM/yyyy")}</label><br>";
                    dia += $"<label>{p.Semana}</label><br>";
                    horario += $"<label>{p.HoraEntradaPadrao} {p.HoraSaidaAlmocoPadrao} {p.HoraVoltaAlmocoPadrao} {p.HoraSaidaPadrao}</label><br>";
                    if (String.IsNullOrEmpty(p.HoraEntrada) && String.IsNullOrEmpty(p.HoraSaidaAlmoco) && String.IsNullOrEmpty(p.HoraVoltaAlmoco) && String.IsNullOrEmpty(p.HoraSaida))
                    {
                        marcacao += $"<label>-</label><br>";
                    }
                    else
                    {
                        marcacao += $"<label>{p.HoraEntrada} {p.HoraSaidaAlmoco} {p.HoraVoltaAlmoco} {p.HoraSaida}</label><br>";
                    }
                    saldo += $"<label>{p.HoraAdicional}</label><br>";
                }
                divData.InnerHtml = data;
                divDia.InnerHtml = dia;
                divHorario.InnerHtml = horario;
                divMarcacao.InnerHtml = marcacao;
                divSaldo.InnerHtml = saldo;
            }
            catch (Exception e)
            {
                messagealert.InnerHtml = e.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
        }
        protected void MarcarPonto()
        {
            try
            {
                PontoController pontoController = new PontoController(_matricula);
                messagealert.InnerHtml = pontoController.MarcarPonto();
                GetPonto();
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
            catch (Exception e)
            {
                messagealert.InnerHtml = e.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }

        }
    }
}