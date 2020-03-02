<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModalCadastro.aspx.cs" Inherits="DPTec.Application.View.ModalCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <div class="modal fade" id="MeusDados" role="dialog">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Meus Dados</h4>
                </div>
                <div class="modal-dialog" style="width: 90%">
                    <div class="form-inline">
                        <div class="border col-md-12">
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <h3>Dados Pessoais</h3>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitNome" runat="server" Text="Nome: "></asp:Label>
                                    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitNomeMae" runat="server" Text="Mãe: "></asp:Label>
                                    <asp:Label ID="lblNomeMae" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitNacionalidade" runat="server" Text="Nacionalidade: "></asp:Label>
                                    <asp:Label ID="lblNacionalidade" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitDataNascimento" runat="server" Text="Data de Nascimento: "></asp:Label>
                                    <asp:Label ID="lblDataNascimento" runat="server" Text="  /  /    "></asp:Label><br />
                                    <asp:Label ID="lblTitEstCivil" runat="server" Text="Estado Civil: "></asp:Label>
                                    <asp:Label ID="lblEstadoCivil" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitPCD" runat="server" Text="Necessidades especiais: "></asp:Label>
                                    <asp:Label ID="lblPCD" runat="server" Text=""></asp:Label><br />
                                </div>
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitMatricula" runat="server" Text="Matrícula: "></asp:Label>
                                    <asp:Label ID="lblMatricula" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitNomePai" runat="server" Text="Pai: "></asp:Label>
                                    <asp:Label ID="lblNomePai" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitNaturalidade" runat="server" Text="Naturalidade: "></asp:Label>
                                    <asp:Label ID="lblNaturalidade" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitSexo" runat="server" Text="Sexo: "></asp:Label>
                                    <asp:Label ID="lblSexo" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitNomeConjuge" runat="server" Text="Conjuge: "></asp:Label>
                                    <asp:Label ID="lblNomeConjuge" runat="server" Text=""></asp:Label><br />
                                </div>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <h3>Documentos</h3>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitNumCTPS" runat="server" Text="N. CTPS: "></asp:Label>
                                    <asp:Label ID="lblNumCTPS" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitDataExpedicaoCTPS" runat="server" Text="Data Expedição: "></asp:Label>
                                    <asp:Label ID="lblDataExpedicaoCTPS" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitRG" runat="server" Text="RG: "></asp:Label>
                                    <asp:Label ID="lblRG" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitCPF" runat="server" Text="CPF: "></asp:Label>
                                    <asp:Label ID="lblCPF" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitZona" runat="server" Text="Zona: "></asp:Label>
                                    <asp:Label ID="lblZona" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitReservista" runat="server" Text="Reservista: "></asp:Label>
                                    <asp:Label ID="lblReservista" runat="server" Text=""></asp:Label><br />
                                </div>
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitSerieCTPS" runat="server" Text="Série: "></asp:Label>
                                    <asp:Label ID="lblSerieCTPS" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitPIS" runat="server" Text="PIS/PASEP: "></asp:Label>
                                    <asp:Label ID="lblPIS" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitDataExpedicaoRG" runat="server" Text="Data Expedição: "></asp:Label>
                                    <asp:Label ID="lblDataExpedicaoRG" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitTituloEleitor" runat="server" Text="N. Titulo Eleitor: "></asp:Label>
                                    <asp:Label ID="lblTituloEleitor" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitSecao" runat="server" Text="Seção: "></asp:Label>
                                    <asp:Label ID="lblSecao" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitRA" runat="server" Text="RA: "></asp:Label>
                                    <asp:Label ID="lblRA" runat="server" Text=""></asp:Label><br />
                                </div>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <h3>Dados Contratuais</h3>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitDataAdmissao" runat="server" Text="Data Admissão: "></asp:Label>
                                    <asp:Label ID="lblDataAdmissao" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitDepartamento" runat="server" Text="Departamento: "></asp:Label>
                                    <asp:Label ID="lblDepartamento" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitTipoContrato" runat="server" Text="Regime Contratação: "></asp:Label>
                                    <asp:Label ID="lblTipoContrato" runat="server" Text=""></asp:Label><br />
                                </div>
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitCargo" runat="server" Text="Cargo: "></asp:Label>
                                    <asp:Label ID="lblCargo" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitCCusto" runat="server" Text="Centro de Custo: "></asp:Label>
                                    <asp:Label ID="lblCCusto" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitStatus" runat="server" Text="Status: "></asp:Label>
                                    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label><br />
                                </div>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <h3>Endereços / Contatos</h3>
                            </div>
                            <div class="form-group col-md-12" style="padding-left: 0px">
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitCEP" runat="server" Text="CEP: "></asp:Label>
                                    <asp:Label ID="lblCEP" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitBairro" runat="server" Text="Bairro: "></asp:Label>
                                    <asp:Label ID="lblBairro" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitTelefone" runat="server" Text="Telefone: "></asp:Label>
                                    <asp:Label ID="lblTelefone" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitTelComercial" runat="server" Text="Tel. Comercial: "></asp:Label>
                                    <asp:Label ID="lblTelComercial" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitMail" runat="server" Text="e-Mail: "></asp:Label>
                                    <asp:Label ID="lblMail" runat="server" Text=""></asp:Label><br />
                                </div>
                                <div class="form-group col-md-6">
                                    <asp:Label ID="lblTitLogradouro" runat="server" Text="Logradouro: "></asp:Label>
                                    <asp:Label ID="lblLogradouro" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitCidade" runat="server" Text="Cidade: "></asp:Label>
                                    <asp:Label ID="lblCidade" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitCelular" runat="server" Text="Celular: "></asp:Label>
                                    <asp:Label ID="lblCelular" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitRamal" runat="server" Text="Ramal: "></asp:Label>
                                    <asp:Label ID="lblRamal" runat="server" Text=""></asp:Label><br />
                                    <asp:Label ID="lblTitMailCom" runat="server" Text="e-Mail Com: "></asp:Label>
                                    <asp:Label ID="lblMailCom" runat="server" Text=""></asp:Label><br />
                                </div>
                            </div>
                        </div>
                        <div class="form-group" style="align: right">
                            <br>
                            <button type="button" class="btn btn-info" data-dismiss="modal">Fechar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</body>
</html>
