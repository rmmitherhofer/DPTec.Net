<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FolhaPonto.aspx.cs" Inherits="DPTec.Application.View.FolhaPonto" %>

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

    <div class="border col-md-12">
        <div class="form-group col-md-6">
            <div>
                <strong>
                    <asp:Label ID="lblTitNome" runat="server" Text="Nome:"></asp:Label>
                    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br>
                </strong>
            </div>
            <div>
                <strong>
                    <asp:Label ID="lblTitMatricula" runat="server" Text="Matricula:"></asp:Label>
                    <asp:Label ID="lblMatricula" runat="server" Text=""></asp:Label><br>
                </strong>
            </div>
            <div>
                <strong>
                    <asp:Label ID="lblTitCPF" runat="server" Text="CPF:"></asp:Label>
                    <asp:Label ID="lblCPF" runat="server" Text=""></asp:Label><br>
                </strong>
            </div>
        </div>
        <div class="form-group col-md-6">
            <div>
                <strong>
                    <asp:Label ID="lblTitCompetencia" runat="server" Text="Compentência:"></asp:Label>
                    <asp:Label ID="lblCompetencia" runat="server" Text=""></asp:Label><br>
                </strong>
            </div>
            <div>
                <strong>
                    <asp:Label ID="lblTitStatus" runat="server" Text="Status:"></asp:Label>
                    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label><br>
                </strong>
            </div>
            <div>
                <strong>
                    <asp:Label ID="lblTitSaldoH" runat="server" Text="Saldo:"></asp:Label>
                    <asp:Label ID="lblSaldoH" runat="server" Text=""></asp:Label>
                </strong>
            </div>
        </div>
        <div class="form-inline col-md-12" >
            <div class="form-group col-md-5" style="float:right">
                <strong>
                    <asp:Label ID="lblTitAno" runat="server" Text="Ano:"></asp:Label>
                </strong>
                <asp:DropDownList ID="dplAno" class="form-control" runat="server"  ClientIDMode="Static">
                    <asp:ListItem Value="0">Selecionar</asp:ListItem>
                    <asp:ListItem Value="2018">2018</asp:ListItem>
                    <asp:ListItem Value="2017">2017</asp:ListItem>
                    <asp:ListItem Value="2016">2016</asp:ListItem>
                </asp:DropDownList>
                <strong>
                    <asp:Label ID="lblTitMes" runat="server" Text="Mês:"></asp:Label>
                </strong>
                <asp:DropDownList ID="dplMes" class="form-control" runat="server" ClientIDMode="Static" AutoPostBack="True" OnSelectedIndexChanged="dplMes_SelectedIndexChanged" >
                    <asp:ListItem Value="0">Selecionar</asp:ListItem>
                    <asp:ListItem Value="1">Janeiro</asp:ListItem>
                    <asp:ListItem Value="2">Fevereiro</asp:ListItem>
                    <asp:ListItem Value="3">Março</asp:ListItem>
                    <asp:ListItem Value="4">Abril</asp:ListItem>
                    <asp:ListItem Value="5">Maio</asp:ListItem>
                    <asp:ListItem Value="6">Junho</asp:ListItem>
                    <asp:ListItem Value="7">Julho</asp:ListItem>
                    <asp:ListItem Value="8">Agosto</asp:ListItem>
                    <asp:ListItem Value="9">Setembro</asp:ListItem>
                    <asp:ListItem Value="10">Outubro</asp:ListItem>
                    <asp:ListItem Value="11">Novembro</asp:ListItem>
                    <asp:ListItem Value="12">Dezembro</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnMarcarPonto" class="btn btn-primary" Style="float: right" runat="server" Text="Marcar Ponto" OnClick="btnMarcarPonto_Click" />
            </div>
        </div>
    </div>

    <div style="text-align: center">
        <label>Efetividade</label>
    </div>
    <div class="form-group border col-md-12" id="gridinfo">
        <div class="form-group col-md-2 border2">
            <label>Data</label>
            <div id="divData" style="background-color: #fff;" runat="server">
            </div>
            <label></label>
        </div>
        <div class="form-group col-md-2	border2">
            <label>Dia</label>
            <div id="divDia" style="background-color: #fff" runat="server">
            </div>
            <label></label>
        </div>
        <div class="form-group col-md-3 border2">
            <label>Horário</label>
            <div id="divHorario" style="background-color: #fff" runat="server">
            </div>
            <label></label>
        </div>
        <div class="form-group col-md-3 border2">
            <label>Marcações Realizadas</label>
            <div id="divMarcacao" style="background-color: #fff" runat="server">
            </div>
            <label></label>
        </div>
        <div class="form-group col-md-2 border2">
            <label>Saldo</label>
            <div id="divSaldo" style="background-color: #fff" runat="server">
            </div>
            <label></label>
        </div>
    </div>
</asp:Content>
