<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModalAlerta.aspx.cs" Inherits="DPTec.Application.View.ModalAlerta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
