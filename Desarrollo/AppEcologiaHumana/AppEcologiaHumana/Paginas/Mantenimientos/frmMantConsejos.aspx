<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMantConsejos.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Mantenimientos.frmMantConsejos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section full mt-2">
        <div class="section-title">Consejo</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic" runat="server" id="dvIdPregunta" visible="false">
                        <div class="input-wrapper">
                            <label class="label" for="lblIdConsejo">Id Consejo</label>
                            <input type="text" class="form-control" runat="server" readonly="readonly" id="txtIdConsejo">
                        </div>
                    </div>
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="lblConsejo">Consejo</label>
                            <input type="text" class="form-control" runat="server" id="txtConsejo" placeholder="Consejo">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlDimensiones">Dimensión</label>
                            <asp:DropDownList ID="ddlDimensiones" class="form-control" runat="server">
                                <asp:ListItem Value="1"> Dimensión 1 </asp:ListItem>
                                <asp:ListItem Value="2"> Dimensión 2 </asp:ListItem>
                                <asp:ListItem Value="3"> Dimensión 3 </asp:ListItem>
                                <asp:ListItem Value="4"> Dimensión 4 </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div>
                        <button type="submit" runat="server" id="btnCrear" onserverclick="btnCrear_ServerClick" class="btn btn-primary btn-block btn-lg">Crear consejo</button>
                        <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
                    </div>

                </div>

            </div>
        </div>
    </div>

</asp:Content>