<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMantUsuarios.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Mantenimientos.frmMantUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Usuario</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic" runat="server" id="dvIdPregunta" visible="false">
                        <div class="input-wrapper">
                            <label class="label" for="lblIdusuario">Id Usuario</label>
                            <input type="text" class="form-control" runat="server" readonly="readonly" id="txtIdUsuario">
                        </div>
                    </div>
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="lblUsuario">Correo electrónico</label>
                            <input type="text" class="form-control" runat="server" id="txtUsuario" placeholder="Correo electrónico">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="lblContrasena">Contraseña</label>
                            <input type="text" class="form-control" runat="server" id="txtContrasena" placeholder="Contraseña">
                            <i class="clear-input">
                                <ion-icon name="close-circle"></ion-icon>
                            </i>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="selectEstado">Estado</label>
                            <select runat="server" class="form-control" id="selectEstado">
                                <option value="A">Activo</option>
                                <option value="I">Inactivo</option>
                            </select>
                        </div>
                    </div>

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="lblNomUsuario">Nombre usuario</label>
                            <input type="text" class="form-control" runat="server" id="txtNombreUsuario" placeholder="Nombre usuario">
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
                            <label class="label" for="ddlProfesiones">Profesión / Nivel de estudios</label>
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

                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <label class="label" for="ddlRol">Rol</label>
                            <asp:DropDownList ID="ddlRol" class="form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>

                    <div>
                        <button type="submit" runat="server" id="btnCrear" onserverclick="btnCrear_ServerClick" class="btn btn-primary btn-block btn-lg">Crear usuario</button>
                        <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
                    </div>

                </div>

            </div>
        </div>

</asp:Content>
