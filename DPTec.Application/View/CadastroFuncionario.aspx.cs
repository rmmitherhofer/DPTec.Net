using DPTec.Application.Controller;
using DPTec.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DPTec.Application.View
{
    public partial class CadastroFuncionario : System.Web.UI.Page
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
                        PreecherDropDown();

                        GetFuncionario();

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
        private void GetFuncionario()
        {
            try
            {
                PerfilController perfil = new PerfilController(_codigoUsuario, 9);
                bool retorno = perfil.ConsultarPerfil();
                if (retorno)
                {
                    FuncionarioController funcionarioController = new FuncionarioController(_matricula);
                    preencherDados(funcionarioController.Consultar());

                }
            }
            catch (Exception e)
            {
                messagealert.InnerHtml = e.Message;
                ScriptManager.RegisterStartupScript(Page, GetType(), "alerta", "$('#alerta').modal();", true);
            }
        }
        private void preencherDados(List<FuncionarioModel> funcionarios)
        {
            foreach (var f in funcionarios)
            {
                #region Identificacao
                txtMatricula.Text = f.Matricula.ToString();
                txtNomeFuncionario.Text = f.NomeFuncionario;
                dplSexo.Text = f.Sexo;
                txtDataNascimento.Text = f.DataNascimento;
                txtNacionalidade.Text = f.Nacionalidade;
                txtNaturalidade.Text = f.Naturalidade;
                dplEstadoCivil.Text = f.EstadoCivil;
                txtNomeConjuge.Text = f.NomeConjuge;
                txtNomeMae.Text = f.NomeMae;
                txtNomePai.Text = f.NomePai;
                dplPcd.Text = f.PCD;
                #endregion

                #region Documentacao                        
                txtCPF.Text = f.NumCPF.ToString();
                txtRG.Text = f.NumRG.ToString();
                txtDtExpedicaoRG.Text = f.DataExpedicaoRG;
                dplOrgaoRG.Text = f.OrgaoExpeditor;
                txtPisPasep.Text = f.NumPIS.ToString();
                txtNReservista.Text = f.NumReservista.ToString();
                txtRAReservista.Text = f.NumRAReservista.ToString();
                txtSerieReservista.Text = f.SiglaSerieReservista;
                txtNTituloEleitoral.Text = f.NumTituloEleitor.ToString();
                txtZonaEleitoral.Text = f.NumZonaEleitor.ToString();
                txtSecaoEleitoral.Text = f.NumSecaoEleitor.ToString();
                txtNCTPS.Text = f.NumCTPS.ToString();
                txtNSerieCTPS.Text = f.NumSerie.ToString();
                dplUFCTPS.Text = f.UFCTPS;
                txtDtExpedicaoCTPS.Text = f.DataExpedicaoCTPS;
                #endregion

                #region Remuneracao
                FinancasController financasController = new FinancasController(0, f.Matricula);
                foreach (var fin in financasController.GetFinancas())
                {
                    dplConta.Text = fin.TipoConta;
                    //dblStatusConta.Text
                    dplBanco.Text = fin.CodigoBanco.ToString();
                    txtNAgencia.Text = fin.Agencia.ToString();
                    txtNConta.Text = fin.Conta.ToString();
                    txtDigito.Text = fin.Digito.ToString();
                    txtSalario.Text = fin.ValorSalarial.ToString();
                }

                #endregion

                #region Contato
                EnderecoController endereco = new EnderecoController(f.numCEP);
                foreach (var end in endereco.BuscarEndereco())
                {
                    txtCEP.Text = end.CEP;
                    txtBairro.Text = end.Bairro;
                    txtLogradouro.Text = end.Logradouro;
                    txtCidade.Text = end.Cidade;
                    dplUFEndereco.Text = end.UF;
                    txtPais.Text = end.Pais;
                }
                txtNumero.Text = f.NumEndereco;
                txtComplemento.Text = f.Complemento;
                txtTelResidencia.Text = f.NumTelefone.ToString();
                txtTelCelular.Text = f.NumTelCelular.ToString();
                txtTelComercial.Text = f.NumTelComercial.ToString();
                txtRamal.Text = f.NumRamal.ToString();
                txtEmail.Text = f.Email;
                txtEmailComercial.Text = f.EmailComercial;
                #endregion


                #region DadoCurricular

                #endregion


                #region DadoContratual
                dplStatusFuncionario.Text = f.StatusFuncionario;
                dplEmpresa.Text = f.Empresa;
                dplDepartamento.Text = f.Departamento.ToString();
                DepartamentoController departamento = new DepartamentoController(f.Departamento);
                foreach (var dep in departamento.GetDepartamento())
                {
                    txtCCusto.Text = dep.CentroCusto;
                    FuncionarioController funcionarioController = new FuncionarioController(dep.MatriculaImediato);
                    var retorno = funcionarioController.Consultar();
                    foreach (var func in retorno)
                    {
                        txtGestor.Text = func.NomeFuncionario;
                        txtGestorCargo.Text = func.Cargo;
                    }
                }
                dplCargo.Text = f.CodigoCargo.ToString();
                dplTipo.Text = f.TipoContrato;
                txtDtAdmissao.Text = f.DataAdmissao;
                txtDtDesligamento.Text = f.DataDesligamento;
                #endregion
            }
        }
        private void PreecherDropDown()
        {
            try
            {
                EstadoCivilController estadoCivilController = new EstadoCivilController(0);
                foreach (var estCivil in estadoCivilController.GetEstadoCivil())
                {
                    dplEstadoCivil.Items.Add(new ListItem(estCivil.EstadoCivil, estCivil.EstadoCivil));
                }

                StatusController statusController = new StatusController(0);
                foreach (var status in statusController.GetStatus())
                {
                    dplStatusConta.Items.Add(new ListItem(status.Descricao, status.Descricao));
                    dplStatusFuncionario.Items.Add(new ListItem(status.Descricao, status.Descricao));
                }

                DepartamentoController departamento = new DepartamentoController(0);
                foreach (var dep in departamento.GetDepartamento())
                {
                    dplDepartamento.Items.Add(new ListItem(dep.DescricaoDepartamento, dep.CodigoDepartamento.ToString()));
                }

                CargoController cargoController = new CargoController(0);
                foreach (var cargo in cargoController.GetCargo())
                {
                    dplCargo.Items.Add(new ListItem(cargo.Cargo, cargo.CodigoCargo.ToString()));
                }

                EmpresaController empresaController = new EmpresaController(0);
                foreach (var emp in empresaController.GetEmpresa())
                {
                    dplEmpresa.Items.Add(new ListItem(emp.NomeRazaoSocial, emp.NomeRazaoSocial.ToString()));
                }

                FinancasController financasController = new FinancasController(0, 0);
                foreach (var banco in financasController.GetBanco())
                {
                    dplBanco.Items.Add(new ListItem(banco.Nome, banco.CodigoBanco.ToString()));
                }
            }
            catch (Exception ex)
            {
                messagealert.InnerHtml = "Desculpe! Ocorreu um erro <br />" + ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "alertaTeste", "$('#alertaTeste').modal();", true);
            }
        }
    }
}