using System;
using DPTec.Application.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DPTec.Application.View
{
    public partial class DefaultMaster : System.Web.UI.Page
    {
        private int _codigoUsuario;
        private int _matricula;
        protected void Page_Load(object sender, EventArgs e)
        {
            btnDadoCadastral.Enabled = false;
            btnFolhaPonto.Enabled = false;
            _codigoUsuario = Convert.ToInt32(Session["codigoUsuario"]);
            _matricula = Convert.ToInt32(Session["matricula"]);

            if (_codigoUsuario > 0)
            {
                PerfilController perfil = new PerfilController(_codigoUsuario, 1);
                bool retorno = perfil.ConsultarPerfil();
                if (retorno == true)
                {
                    btnFolhaPonto.Enabled = true;
                    btnDadoCadastral.Enabled = true;
                }
            }
            else
            {
                messagealert.InnerHtml = "Usuario Não Autenticado";
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
                Response.Redirect($"~/Default.aspx", false);
            }

        }
        protected void btnFolhaPonto_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Add("codigoUsuario", _codigoUsuario);
                Session.Add("matricula", _matricula);
                Response.Redirect($"~/View/FolhaPonto.aspx", false);
            }
            catch (Exception)
            {

                throw;
            }

        }
        protected void btnDadoCadastral_Click(object sender, EventArgs e)
        {
            try
            {
                GetFuncionario();
                ScriptManager.RegisterStartupScript(Page, GetType(), "MeusDados", "$('#MeusDados').modal();", true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void GetFuncionario()
        {
            try
            {
                PerfilController perfil = new PerfilController(_codigoUsuario, 4);
                bool retorno = perfil.ConsultarPerfil();
                if (retorno)
                {
                    FuncionarioController funcionarioController = new FuncionarioController(_matricula);
                    var funcionarios = funcionarioController.Consultar();
                    foreach (var f in funcionarios)
                    {
                        lblNome.Text = f.NomeFuncionario;
                        lblNomeMae.Text = f.NomeMae;
                        lblNacionalidade.Text = f.Nacionalidade;
                        lblDataNascimento.Text = f.DataNascimento;
                        lblEstadoCivil.Text = f.EstadoCivil.ToString();
                        lblPCD.Text = f.PCD;

                        lblMatricula.Text = f.Matricula.ToString();
                        lblNomePai.Text = f.NomePai;
                        lblNaturalidade.Text = f.Naturalidade;
                        lblSexo.Text = f.Sexo;
                        lblNomeConjuge.Text = f.NomeConjuge;

                        lblNumCTPS.Text = f.NumCTPS.ToString();
                        lblDataExpedicaoCTPS.Text = f.DataExpedicaoCTPS;
                        lblRG.Text = f.NumRG.ToString();
                        lblCPF.Text = f.NumCPF.ToString();
                        lblZona.Text = f.NumZonaEleitor.ToString();
                        lblReservista.Text = f.NumReservista.ToString();

                        lblSerieCTPS.Text = f.NumSerie.ToString();
                        lblPIS.Text = f.NumPIS.ToString();
                        lblDataExpedicaoRG.Text = f.DataExpedicaoRG;
                        lblTituloEleitor.Text = f.NumTituloEleitor.ToString();
                        lblSecao.Text = f.NumSecaoEleitor.ToString();
                        lblRA.Text = f.NumRAReservista.ToString() + " - " + f.SiglaSerieReservista;

                        lblDataAdmissao.Text = f.DataAdmissao;
                        DepartamentoController departamento = new DepartamentoController(f.Departamento);
                        foreach (var dep in departamento.GetDepartamento())
                        {
                            lblDepartamento.Text = dep.DescricaoDepartamento;
                            lblCCusto.Text = dep.CentroCusto;
                        }

                        lblTipoContrato.Text = f.TipoContrato;

                        lblCargo.Text = f.Cargo.ToString();
                        lblStatus.Text = f.StatusFuncionario;

                        EnderecoController endereco = new EnderecoController(f.numCEP);
                        foreach (var end in endereco.BuscarEndereco())
                        {
                            lblCEP.Text = end.CEP;
                            lblBairro.Text = end.Bairro;
                            lblLogradouro.Text = end.Logradouro + ", " + f.NumEndereco + " " + f.Complemento;
                            lblCidade.Text = end.Cidade;
                        }

                        lblTelefone.Text = f.NumTelefone.ToString();
                        lblTelComercial.Text = f.NumTelCelular.ToString();
                        lblMail.Text = f.Email;

                        lblCelular.Text = f.NumTelCelular.ToString();
                        lblRamal.Text = f.NumRamal.ToString();
                        lblMailCom.Text = f.EmailComercial;

                    }
                }
            }
            catch (Exception e)
            {
                messagealert.InnerHtml = e.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
        }
    }
}