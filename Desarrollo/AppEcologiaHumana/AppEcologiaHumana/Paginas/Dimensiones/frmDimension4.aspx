<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDimension4.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Dimensiones.frmDimension4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Div1" runat="server">

        <div class="section mt-2 mb-2">

            <div class="goals">
                <!-- item -->
                <div class="item">
                    <div class="in">
                        <div>
                            <h4>Dimensión 4</h4>
                            <p runat="server" id="lblResDim4">000/000</p>
                        </div>
                        <div class="img-wrapper">
                            <img src="../../assets/img/dimension4.png" alt="img" class="image-block imaged w48">
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div id="dvMensaje" runat="server">
        <div class="section mt-2 mb-2">

            <div class="goals">
                <!-- item -->
                <div class="item">
                    <div class="in">
                        <div>
                            <h4>Respuestas ya han sido enviadas para la dimensión 4, intentelo el día de mañana.</h4>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>

    <div id="appCapsule" runat="server">

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
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <input type="hidden" class="custom-control-input" runat="server" id="txtCantPregFrec">
                    <input type="hidden" class="custom-control-input" runat="server" id="txtCantPregTen">
                    <asp:TextBox ID="txtCantPregTen12" runat="server" Style="display: none;"></asp:TextBox>
                    <asp:TextBox ID="txtCantPregFrec12" runat="server" Style="display: none;"></asp:TextBox>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="accordion" id="accordionExample1">
                <asp:Repeater ID="rptFrecuencia" runat="server">
                    <ItemTemplate>
                        <div class="item">
                            <div class="accordion-header" style="height: 150px;">
                                <div class="left">
                                    <button class="btn collapsed" type="button" style="height: 150px;" data-toggle="collapse" data-target="#accordion<%#Eval("IdPregunta")%>">
                                        <div class="left">
                                            <img src="../../assets/img/Imagen<%#Eval("Tipo")%>.png" alt="img" class="image-block imaged w36">
                                        </div>
                                        <%#Eval("Pregunta")%>
                                    </button>
                                </div>

                            </div>
                            <div id="accordion<%#Eval("IdPregunta")%>" class="accordion-body collapse" data-parent="#accordionExample1">
                                <div class="section full mt-1 mb-2">
                                    <div class="wide-block pt-2 pb-2">

                                        <div class="custom-control custom-checkbox mb-1">
                                            <input type="checkbox" class="custom-control-input" name="group<%#Eval("IdPregunta")%>[]" id="Frec0-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Frec0-<%#Eval("IdPregunta")%>">Nunca</label>
                                        </div>
                                        <div class="custom-control custom-checkbox mb-1">
                                            <input type="checkbox" class="custom-control-input" name="group<%#Eval("IdPregunta")%>[]" id="Frec1-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Frec1-<%#Eval("IdPregunta")%>">Pocas veces</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group<%#Eval("IdPregunta")%>[]" id="Frec2-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Frec2-<%#Eval("IdPregunta")%>">La mayoría de veces</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group<%#Eval("IdPregunta")%>[]" id="Frec3-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Frec3-<%#Eval("IdPregunta")%>">Siempre</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group<%#Eval("IdPregunta")%>[]" id="Frec4-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Frec4-<%#Eval("IdPregunta")%>">No aplica</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>


            <div class="accordion" id="accordionExample2">
                <asp:Repeater ID="rptTenencia" runat="server">
                    <ItemTemplate>

                        <div class="item">
                            <div class="accordion-header" style="height: 150px;">
                                <button class="btn collapsed" type="button" style="height: 150px;" data-toggle="collapse" data-target="#accordion<%#Eval("IdPregunta")%>">
                                    <input type="hidden" id="IdPregunta<%#Eval("IdPregunta")%>" value="<%#Eval("IdPregunta")%>">
                                    <div class="left">
                                        <img src="../../assets/img/Imagen<%#Eval("Tipo")%>.png" alt="img" class="image-block imaged w36">
                                    </div>
                                    <%#Eval("Pregunta")%>
                                </button>
                            </div>
                            <div id="accordion<%#Eval("IdPregunta")%>" class="accordion-body collapse" data-parent="#accordionExample2">
                                <div class="section full mt-1 mb-2">
                                    <div class="wide-block pt-2 pb-2">

                                        <div class="custom-control custom-checkbox mb-1">
                                            <input type="checkbox" class="custom-control-input" name="group2<%#Eval("IdPregunta")%>[]" id="Ten0-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Ten0-<%#Eval("IdPregunta")%>">Ninguno</label>
                                        </div>
                                        <div class="custom-control custom-checkbox mb-1">
                                            <input type="checkbox" class="custom-control-input" name="group2<%#Eval("IdPregunta")%>[]" id="Ten1-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Ten1-<%#Eval("IdPregunta")%>">Menos de la mitad</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group2<%#Eval("IdPregunta")%>[]" id="Ten2-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Ten2-<%#Eval("IdPregunta")%>">Más de la mitad</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group2<%#Eval("IdPregunta")%>[]" id="Ten3-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Ten3-<%#Eval("IdPregunta")%>">Todos</label>
                                        </div>
                                        <div class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" name="group2<%#Eval("IdPregunta")%>[]" id="Ten4-<%#Eval("IdPregunta")%>">
                                            <label class="custom-control-label" for="Ten4-<%#Eval("IdPregunta")%>">No aplica</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

        </div>
        <div>
            <asp:Button ID="btnCrear" OnClientClick="return ObtenerSeleccionados();" OnClick="btnCrear_ServerClick" runat="server" Text="Guardar respuestas" class="btn btn-primary btn-block btn-lg" />
            <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
            <label class="label" visible="false" style="color: red;" id="lblMensajes"></label>
        </div>
    </div>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="../../JavaScript/Dimensiones/Dimension1Js.js"></script>
</asp:Content>
