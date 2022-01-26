<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProgreso.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Perfil.frmProgreso" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Progreso dimensión</div>
        <div class="goals">
            <div class="item">
                <div class="in">
                    <div>
                        <a href="#" runat="server" id="imgDim1" onserverclick="imgDim1_ServerClick">
                            <img src="../../assets/img/dimension1.png" alt="img" class="image-block imaged w48"></a>

                        <p>Dimensión 1</p>
                    </div>
                    <div>
                        <a href="#" runat="server" id="imgDim2" onserverclick="imgDim2_ServerClick">
                            <img src="../../assets/img/dimension2.png" alt="img" class="image-block imaged w48"></a>
                        <p>Dimensión 2</p>
                    </div>
                    <div>
                        <a href="#" runat="server" id="imgDim3" onserverclick="imgDim3_ServerClick">
                            <img src="../../assets/img/dimension3.png" alt="img" class="image-block imaged w48"></a>
                        <p>Dimensión 3</p>
                    </div>
                    <div>
                        <a href="#" runat="server" id="imgDim4" onserverclick="imgDim4_ServerClick">
                            <img src="../../assets/img/dimension4.png" alt="img" class="image-block imaged w48"></a>
                        <p>Dimensión 4</p>
                    </div>
                </div>
            </div>
            <!-- * item -->
        </div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <center>
                    <asp:UpdatePanel ID="updPanel" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="section mt-2 mb-5 p-3">
                                <asp:Chart ID="Graficas" runat="server">
                                    <Series>
                                        <asp:Series Name="Serie" IsValueShownAsLabel="true"></asp:Series>
                                    </Series>
                                    <ChartAreas>
                                        <asp:ChartArea Name="ChartArea"></asp:ChartArea>
                                    </ChartAreas>
                                </asp:Chart>

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </center>


            </div>
        </div>
    </div>

</asp:Content>
