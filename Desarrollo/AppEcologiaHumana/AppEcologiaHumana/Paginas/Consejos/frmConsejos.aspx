<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmConsejos.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Consejos.frmConsejos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="appCapsule">
        <div class="section mt-2 mb-2">
            <asp:Repeater ID="rptConsejos" runat="server">
                <ItemTemplate>

                    <div class="goals">
                        <div class="item">
                            <div class="in">
                                <div>
                                    <h4><%#Eval("Consejo")%></h4>
                                </div>
                                <div class="img-wrapper">
                                    <img src="../../assets/img/dimension<%#Eval("Dimension")%>.png" alt="img" class="image-block imaged w48">
                                </div>
                            </div>
                        </div>
                    </div>

                    <br />
                </ItemTemplate>

            </asp:Repeater>
        </div>
    </div>
</asp:Content>
