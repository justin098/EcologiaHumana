<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmIndex.aspx.cs" Inherits="AppEcologiaHumana.Paginas.frmIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Monthly Bills -->
    <div class="section">

        <div class="section full mt-4">
            <div class="row mt-2">
                <div class="col-6">
                    <div class="bill-box">
                        <div class="img-wrapper">
                            <img src="../assets/img/dimension1.png" alt="img" class="image-block imaged w48">
                        </div>
                        <div class="price" id="lblResDim1" runat="server">0000/0000</div>
                        <a href="Dimensiones/frmDimension1.aspx" runat="server" id="btnDimension1" class="btn btn-primary btn-block btn-sm">Dimensión 1</a>
                    </div>
                </div>
                <div class="col-6">
                    <div class="bill-box">
                        <div class="img-wrapper">
                            <img src="../assets/img/dimension2.png" alt="img" class="image-block imaged w48">
                        </div>
                        <div class="price" id="lblResDim2" runat="server">0000/0000</div>
                        <a href="Dimensiones/frmDimension2.aspx" runat="server" id="btnDimension2" class="btn btn-primary btn-block btn-sm">Dimensión 2</a>
                    </div>
                </div>
            </div>


        </div>

        <div class="section full mt-4">
            <div class="row mt-2">
                <div class="col-6">
                    <div class="bill-box">
                        <div class="img-wrapper">
                            <img src="../assets/img/dimension3.png" alt="img" class="image-block imaged w48">
                        </div>
                        <div class="price"  id="lblResDim3" runat="server">0000/0000</div>
                        <a href="Dimensiones/frmDimension3.aspx" runat="server" id="btnDimension3" class="btn btn-primary btn-block btn-sm">Dimensión 3</a>
                    </div>
                </div>
                <div class="col-6">
                    <div class="bill-box">
                        <div class="img-wrapper">
                            <img src="../assets/img/dimension4.png" alt="img" class="image-block imaged w48">
                        </div>
                        <div class="price"  id="lblResDim4" runat="server">0000/0000</div>
                        <a href="Dimensiones/frmDimension4.aspx" runat="server" id="btnDimension4" class="btn btn-primary btn-block btn-sm">Dimensión 4</a>
                    </div>
                </div>
            </div>


        </div>

    </div>
</asp:Content>
