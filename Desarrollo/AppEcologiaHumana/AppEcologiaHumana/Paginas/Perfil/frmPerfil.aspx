<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPerfil.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Perfil.frmPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Perfil</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="txtUsuario">Nombre de usuario</label>
                            <input type="text" class="form-control" runat="server" id="txtUsuario" placeholder="Nombre de usuario">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="txtFechaNac">Fecha de nacimiento</label>
                            <input type="date" class="form-control" id="txtFechaNac" runat="server" placeholder="Fecha de nacimiento">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlSedes">Sede / Provincia</label>
                            <asp:DropDownList ID="ddlSedes" class="form-control" runat="server"></asp:DropDownList>

                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlProfesiones">Rol / Profesión / Nivel de estudios</label>
                            <asp:DropDownList ID="ddlProfesiones" class="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>


                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="selectSexo">Sexo</label>
                            <select runat="server" class="form-control" id="selectSexo">
                                <option value="H">Hombre</option>
                                <option value="M">Mujer</option>
                            </select>
                        </div>
                    </div>

                    <div>
                        <button type="submit" id="btnCrear" onserverclick="btnCrear_ServerClick" runat="server" class="btn btn-primary btn-block btn-lg">Guardar cambios</button>
                        <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
                        <br />
                        <br />
                        <br />
                        <center><img src="../../assets/img/statistics.png" alt="img" class="image-block imaged w64"/></center>
                        <button type="submit" id="btnProgreso" onserverclick="btnProgreso_ServerClick" runat="server" class="btn btn-primary btn-block btn-lg">Ver progreso</button>

                    </div>

                </div>

            </div>
        </div>
    </div>

</asp:Content>
