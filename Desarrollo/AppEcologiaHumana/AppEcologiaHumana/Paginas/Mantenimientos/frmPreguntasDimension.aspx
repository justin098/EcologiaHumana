<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPreguntasDimension.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Mantenimientos.frmPreguntasDimension" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section mt-2 mb-2">

        <div class="goals">
            <div class="item">
                <div class="in">
                    <div>
                        <img src="../../assets/img/Imagen1.png" alt="img" class="image-block imaged w48">
                        <p>Principiante</p>
                    </div>
                    <div>
                        <img src="../../assets/img/Imagen2.png" alt="img" class="image-block imaged w48">
                        <p>Promedio</p>
                    </div>
                    <div>
                        <img src="../../assets/img/Imagen3.png" alt="img" class="image-block imaged w48">
                        <p>Hábil</p>
                    </div>
                    <div>
                        <img src="../../assets/img/Imagen4.png" alt="img" class="image-block imaged w48">
                        <p>Especialista</p>
                    </div>
                    <div>
                        <img src="../../assets/img/Imagen5.png" alt="img" class="image-block imaged w48">
                        <p>Experto</p>
                    </div>
                </div>
            </div>
            <!-- * item -->
        </div>

    </div>
    <div class="section full mt-2">
        <div class="section-title">Pregunta</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic" runat="server" id="dvIdPregunta" visible="false">
                        <div class="input-wrapper">
                            <label class="label" for="lblIdPregunta">Id Pregunta</label>
                            <input type="text" class="form-control" runat="server" readonly="readonly" id="txtIdPregunta">
                        </div>
                    </div>
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="lblPregunta">Pregunta</label>
                            <input type="text" class="form-control" runat="server" id="txtPregunta" placeholder="Pregunta">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlTipoPregunta">Tipo pregunta</label>
                            <asp:DropDownList ID="ddlTipoPregunta" class="form-control" runat="server">
                                <asp:ListItem Value="1"> Principiante </asp:ListItem>
                                <asp:ListItem Value="2"> Promedio </asp:ListItem>
                                <asp:ListItem Value="3"> Hábil </asp:ListItem>
                                <asp:ListItem Value="4"> Especialista </asp:ListItem>
                                <asp:ListItem Value="5"> Experto </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlEstiloPregunta">Estilo pregunta</label>
                            <asp:DropDownList ID="ddlEstiloPregunta" class="form-control" runat="server">
                                <asp:ListItem Value="1"> Frecuencia </asp:ListItem>
                                <asp:ListItem Value="2"> Tenencia </asp:ListItem>
                            </asp:DropDownList>
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
                                <asp:ListItem Value="5"> Dimensión 5 </asp:ListItem>
                                <asp:ListItem Value="6"> Dimensión 6 </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div>
                        <button type="submit" runat="server" id="btnCrear" onserverclick="btnCrear_ServerClick" class="btn btn-primary btn-block btn-lg">Crear pregunta</button>
                        <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
                    </div>

                </div>

            </div>
        </div>
    </div>

</asp:Content>
