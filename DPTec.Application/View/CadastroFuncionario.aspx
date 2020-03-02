<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="DPTec.Application.View.CadastroFuncionario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="modal fade" id="alerta" data-backdrop="false" style="background-color: rgba(0, 0, 0, 0.5)" role="dialog" aria-labelledby="modalAlertaTeste">
        <div class="vertical-alignment-helper">
            <div class="modal-dialog" style="left: 0%;">
                <div class="modal-content">
                    <div class="modal-header">
                        <h3 class="modal-title">Atenção</h3>
                        <button type="btnX" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h4 id="messagealert" runat="server"></h4>
                    </div>
                    <div class="modal-footer">
                        <asp:Button type="btnSair" class="btn btn-secondary" data-dismiss="modal">Fechar</asp:Button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="Identificacao" class="form-group">
        <asp:Label ID="lblMatricula" runat="server" Text="Matricula"></asp:Label>
        <asp:TextBox ID="txtMatricula" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNomeFuncionario" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
        <asp:DropDownList ID="dplSexo" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
            <asp:ListItem Value="Feminino">Feminino</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblDataNascimento" runat="server" Text="Data Nascimento"></asp:Label>
        <asp:TextBox ID="txtDataNascimento" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNacionalidade" runat="server" Text="Nacionalidade"></asp:Label>
        <asp:TextBox ID="txtNacionalidade" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNaturalidade" runat="server" Text="Naturalidade"></asp:Label>
        <asp:TextBox ID="txtNaturalidade" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblEstadoCivil" runat="server" Text="Estado Civil"></asp:Label>
        <asp:DropDownList ID="dplEstadoCivil" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblNomeConjuge" runat="server" Text="Nome Conjuge"></asp:Label>
        <asp:TextBox ID="txtNomeConjuge" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNomeMae" runat="server" Text="Nome Mãe"></asp:Label>
        <asp:TextBox ID="txtNomeMae" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNomePai" runat="server" Text="Nome Pai"></asp:Label>
        <asp:TextBox ID="txtNomePai" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblPCD" runat="server" Text="Possui Necessidades Especiais?"></asp:Label>
        <asp:DropDownList ID="dplPcd" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="Nenhuma">Nenhuma</asp:ListItem>
            <asp:ListItem Value="Autismo">Autismo</asp:ListItem>
            <asp:ListItem Value="Doença Crônica">Doença Crônica</asp:ListItem>
            <asp:ListItem Value="Perda Auditiva e Surdez">Perda Auditiva e Surdez</asp:ListItem>
            <asp:ListItem Value="Deficiência Intelectual">Deficiência Intelectual</asp:ListItem>
            <asp:ListItem Value="Deficiência de Aprendizado">Deficiência de Aprendizado</asp:ListItem>
            <asp:ListItem Value="Perda de Memória">Perda de Memória</asp:ListItem>
            <asp:ListItem Value="Deficiência Mental">Deficiência Mental</asp:ListItem>
            <asp:ListItem Value="Deficiência Física">Deficiência Física</asp:ListItem>
            <asp:ListItem Value="Distúrbios da Fala e da Linguagem">Distúrbios da Fala e da Linguagem</asp:ListItem>
            <asp:ListItem Value="Perda de Visão e Cegueira">Perda de Visão e Cegueira</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div id="Documentacao" class="form-group">
        <asp:Label ID="lblCPF" runat="server" Text="CPF"></asp:Label>
        <asp:TextBox ID="txtCPF" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblRG" runat="server" Text="RG"></asp:Label>
        <asp:TextBox ID="txtRG" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblOrgaoRG" runat="server" Text="Orgão de Expedição"></asp:Label>
        <asp:DropDownList ID="dplOrgaoRG" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="SSP">SSP</asp:ListItem>
            <asp:ListItem Value="PM">PM</asp:ListItem>
            <asp:ListItem Value="PC">PC</asp:ListItem>
            <asp:ListItem Value="CNT">CNT</asp:ListItem>
            <asp:ListItem Value="DIC">DIC</asp:ListItem>
            <asp:ListItem Value="CTPS">CTPS</asp:ListItem>
            <asp:ListItem Value="FGTS">FGTS</asp:ListItem>
            <asp:ListItem Value="IFP">IFP</asp:ListItem>
            <asp:ListItem Value="IPF">IPF</asp:ListItem>
            <asp:ListItem Value="IML">IML</asp:ListItem>
            <asp:ListItem Value="MTE">MTE</asp:ListItem>
            <asp:ListItem Value="MMA">MMA</asp:ListItem>
            <asp:ListItem Value="MAE">MAE</asp:ListItem>
            <asp:ListItem Value="MEX">MEX</asp:ListItem>
            <asp:ListItem Value="POF">POF</asp:ListItem>
            <asp:ListItem Value="POM">POM</asp:ListItem>
            <asp:ListItem Value="SES">SES</asp:ListItem>
            <asp:ListItem Value="SJS">SJS</asp:ListItem>
            <asp:ListItem Value="SJTS">SJTS</asp:ListItem>
            <asp:ListItem Value="ZZZ">ZZZ</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblDtExpedicaoRG" runat="server" Text="Data de Expedição"></asp:Label>
        <asp:TextBox ID="txtDtExpedicaoRG" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblPIS" runat="server" Text="Numero PIS/PASEP"></asp:Label>
        <asp:TextBox ID="txtPisPasep" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNReservista" runat="server" Text="Numero da Reservista"></asp:Label>
        <asp:TextBox ID="txtNReservista" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblRAReservista" runat="server" Text="RA"></asp:Label>
        <asp:TextBox ID="txtRAReservista" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblSerieReservista" runat="server" Text="Serie"></asp:Label>
        <asp:TextBox ID="txtSerieReservista" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNTituloEleitoral" runat="server" Text="Titulo de Eleitor"></asp:Label>
        <asp:TextBox ID="txtNTituloEleitoral" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblZonaEleitoral" runat="server" Text="Zona Eleitoral"></asp:Label>
        <asp:TextBox ID="txtZonaEleitoral" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblSecaoEleitoral" runat="server" Text="Seção Eleitoral"></asp:Label>
        <asp:TextBox ID="txtSecaoEleitoral" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNCTPS" runat="server" Text="CTPS"></asp:Label>
        <asp:TextBox ID="txtNCTPS" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNSerieCTPS" runat="server" Text="Série"></asp:Label>
        <asp:TextBox ID="txtNSerieCTPS" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblUFCTPS" runat="server" Text="UF"></asp:Label>
        <asp:DropDownList ID="dplUFCTPS" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="AC">AC</asp:ListItem>
            <asp:ListItem Value="AL">AL</asp:ListItem>
            <asp:ListItem Value="AP">AP</asp:ListItem>
            <asp:ListItem Value="AM">AM</asp:ListItem>
            <asp:ListItem Value="BA">BA</asp:ListItem>
            <asp:ListItem Value="CE">CE</asp:ListItem>
            <asp:ListItem Value="DF">DF</asp:ListItem>
            <asp:ListItem Value="ES">ES</asp:ListItem>
            <asp:ListItem Value="GO">GO</asp:ListItem>
            <asp:ListItem Value="MA">MA</asp:ListItem>
            <asp:ListItem Value="MT">MT</asp:ListItem>
            <asp:ListItem Value="MS">MS</asp:ListItem>
            <asp:ListItem Value="MG">MG</asp:ListItem>
            <asp:ListItem Value="PA">PA</asp:ListItem>
            <asp:ListItem Value="PB">PB</asp:ListItem>
            <asp:ListItem Value="PR">PR</asp:ListItem>
            <asp:ListItem Value="PE">PE</asp:ListItem>
            <asp:ListItem Value="PI">PI</asp:ListItem>
            <asp:ListItem Value="RJ">RJ</asp:ListItem>
            <asp:ListItem Value="RN">RN</asp:ListItem>
            <asp:ListItem Value="RS">RS</asp:ListItem>
            <asp:ListItem Value="RO">RO</asp:ListItem>
            <asp:ListItem Value="RR">RR</asp:ListItem>
            <asp:ListItem Value="SC">SC</asp:ListItem>
            <asp:ListItem Value="SP">SP</asp:ListItem>
            <asp:ListItem Value="SE">SE</asp:ListItem>
            <asp:ListItem Value="TO">TO</asp:ListItem>

        </asp:DropDownList>
        <asp:Label ID="lblDtExpedicaoCTPS" runat="server" Text="Data de Expedição"></asp:Label>
        <asp:TextBox ID="txtDtExpedicaoCTPS" runat="server" class="form-control"></asp:TextBox>
    </div>
    <div id="Remuneracao" class="form-group">
        <asp:Label ID="lblConta" runat="server" Text="Tipo de Conta"></asp:Label>
        <asp:DropDownList ID="dplConta" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="Conta Corrente">Conta Corrente</asp:ListItem>
            <asp:ListItem Value="Conta Poupança">Conta Poupança</asp:ListItem>
            <asp:ListItem Value="Conta Salário">Conta Salário</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblStatusConta" runat="server" Text="Status"></asp:Label>
        <asp:DropDownList ID="dplStatusConta" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblBanco" runat="server" Text="Banco"></asp:Label>
        <asp:DropDownList ID="dplBanco" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblNAgencia" runat="server" Text="Numero da Agencia"></asp:Label>
        <asp:TextBox ID="txtNAgencia" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNConta" runat="server" Text="Numero da Conta"></asp:Label>
        <asp:TextBox ID="txtNConta" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblDigito" runat="server" Text="Digito"></asp:Label>
        <asp:TextBox ID="txtDigito" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblSalario" runat="server" Text="Valo Salárial"></asp:Label>
        <asp:TextBox ID="txtSalario" runat="server" class="form-control"></asp:TextBox>
    </div>
    <div id="Contato" class="form-group">
        <asp:Label ID="lblCEP" runat="server" Text="CEP"></asp:Label>
        <asp:TextBox ID="txtCEP" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblLogradouro" runat="server" Text="Logradouro"></asp:Label>
        <asp:TextBox ID="txtLogradouro" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblNumero" runat="server" Text="Número"></asp:Label>
        <asp:TextBox ID="txtNumero" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblComplemento" runat="server" Text="Complemento"></asp:Label>
        <asp:TextBox ID="txtComplemento" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblBairro" runat="server" Text="Bairro"></asp:Label>
        <asp:TextBox ID="txtBairro" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblCidade" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblUFEndereco" runat="server" Text="UF"></asp:Label>
        <asp:DropDownList ID="dplUFEndereco" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="AC">AC</asp:ListItem>
            <asp:ListItem Value="AL">AL</asp:ListItem>
            <asp:ListItem Value="AP">AP</asp:ListItem>
            <asp:ListItem Value="AM">AM</asp:ListItem>
            <asp:ListItem Value="BA">BA</asp:ListItem>
            <asp:ListItem Value="CE">CE</asp:ListItem>
            <asp:ListItem Value="DF">DF</asp:ListItem>
            <asp:ListItem Value="ES">ES</asp:ListItem>
            <asp:ListItem Value="GO">GO</asp:ListItem>
            <asp:ListItem Value="MA">MA</asp:ListItem>
            <asp:ListItem Value="MT">MT</asp:ListItem>
            <asp:ListItem Value="MS">MS</asp:ListItem>
            <asp:ListItem Value="MG">MG</asp:ListItem>
            <asp:ListItem Value="PA">PA</asp:ListItem>
            <asp:ListItem Value="PB">PB</asp:ListItem>
            <asp:ListItem Value="PR">PR</asp:ListItem>
            <asp:ListItem Value="PE">PE</asp:ListItem>
            <asp:ListItem Value="PI">PI</asp:ListItem>
            <asp:ListItem Value="RJ">RJ</asp:ListItem>
            <asp:ListItem Value="RN">RN</asp:ListItem>
            <asp:ListItem Value="RS">RS</asp:ListItem>
            <asp:ListItem Value="RO">RO</asp:ListItem>
            <asp:ListItem Value="RR">RR</asp:ListItem>
            <asp:ListItem Value="SC">SC</asp:ListItem>
            <asp:ListItem Value="SP">SP</asp:ListItem>
            <asp:ListItem Value="SE">SE</asp:ListItem>
            <asp:ListItem Value="TO">TO</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblPais" runat="server" Text="País"></asp:Label>
        <asp:TextBox ID="txtPais" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblTelResidencia" runat="server" Text="Telefone Residencial"></asp:Label>
        <asp:TextBox ID="txtTelResidencia" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblTelCelular" runat="server" Text="Telecone Celular"></asp:Label>
        <asp:TextBox ID="txtTelCelular" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblTelComercial" runat="server" Text="Telecone Comercial"></asp:Label>
        <asp:TextBox ID="txtTelComercial" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblRamal" runat="server" Text="Ramal"></asp:Label>
        <asp:TextBox ID="txtRamal" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" Text="e-Mail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblEmailComercial" runat="server" Text="e-Mail Comercial"></asp:Label>
        <asp:TextBox ID="txtEmailComercial" runat="server" class="form-control"></asp:TextBox>
    </div>
    <div id="DadoCurricular" class="form-group">
        <asp:Label ID="lblEscolaridade" runat="server" Text="Escolaridade"></asp:Label>
        <asp:Table ID="tblEscolaridade" runat="server" class="form-control"></asp:Table>
        <asp:Label ID="lblDadoProfissional" runat="server" Text="Dados Profissionais"></asp:Label>
        <asp:Table ID="tblDadoProfissional" runat="server" class="form-control"></asp:Table>
        <asp:Label ID="lblCurso" runat="server" Text="Cursos"></asp:Label>
        <asp:Table ID="tblCurso" runat="server" class="form-control"></asp:Table>
    </div>
    <div id="DadoContratual" class="form-group">
        <asp:Label ID="lblStatusFuncionario" runat="server" Text="Status do Funcionário"></asp:Label>
        <asp:DropDownList ID="dplStatusFuncionario" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblEmpresa" runat="server" Text="Nome da Empresa"></asp:Label>
        <asp:DropDownList ID="dplEmpresa" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblDepartamento" runat="server" Text="Departamento"></asp:Label>
        <asp:DropDownList ID="dplDepartamento" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblCCusto" runat="server" Text="Centro de Custo"></asp:Label>
        <asp:TextBox ID="txtCCusto" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblCargo" runat="server" Text="Cargo"></asp:Label>
        <asp:DropDownList ID="dplCargo" runat="server" class="form-control">
            <asp:ListItem Value="0">Selecionar</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblTipo" runat="server" Text="Regime Contratual"></asp:Label>
        <asp:DropDownList ID="dplTipo" runat="server" class="form-control">
            <asp:ListItem Value="Selecionar">Selecionar</asp:ListItem>
            <asp:ListItem Value="CLT">CLT</asp:ListItem>
            <asp:ListItem Value="Terceiro">Terceiro</asp:ListItem>
            <asp:ListItem Value="PJ">PJ</asp:ListItem>
            <asp:ListItem Value="Parceiro">Parceiro</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblGestor" runat="server" Text="Gestor Imediato"></asp:Label>
        <asp:TextBox ID="txtGestor" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblGestorCargo" runat="server" Text="Cargo Gestor Imediato"></asp:Label>
        <asp:TextBox ID="txtGestorCargo" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblDtAdmissao" runat="server" Text="Data de Admissão"></asp:Label>
        <asp:TextBox ID="txtDtAdmissao" runat="server" class="form-control"></asp:TextBox>
        <asp:Label ID="lblDtDesligamento" runat="server" Text="Data de Desligamento"></asp:Label>
        <asp:TextBox ID="txtDtDesligamento" runat="server" class="form-control"></asp:TextBox>
    </div>
</asp:Content>
