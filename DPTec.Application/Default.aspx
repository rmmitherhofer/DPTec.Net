<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DPTec.Application._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .Campos {
            width: 400px;
        }

        .div {
            margin-left: 28%;
            width: 500px;
            height: 300px;
            background-color: #fff;
            border-radius: 10px;
        }

        body {
            background-color: #5FB9F2;
        }
    </style>

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

    <div class="container div">
        <h2>DPTec</h2>
        <div class="form-group">
            <asp:Panel runat="server" ID="pnlMatricula" DefaultButton="btnAcessar">
                <div class="form-group">
                    <asp:Label for="Login" ID="lblLogin" runat="server" Text="Login"></asp:Label>
                    <asp:TextBox ID="txtLogin" class="form-control Campos" placeholder="Login" name="Login" runat="server" required="required" MaxLength="20"></asp:TextBox>
                </div>
                <div class="form-group ">
                    <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
                    <input id="txtSenha" type="password" class="form-control Campos" placeholder="Senha" name="Senha" runat="server" clientidmode="static" required="required" maxlength="10" />
                </div>
                <asp:Button ID="btnAcessar" class="btn btn-primary" runat="server" Text="Acessar" OnClick="btnAcessar_Click" />
            </asp:Panel>
        </div>
    </div>
</asp:Content>
