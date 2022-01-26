<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmUsuarios.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Mantenimientos.frmUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="section full mt-2">
        <div class="section-title">Usuarios</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <a href="<%= HttpContext.Current.Request.ApplicationPath %>Paginas/Mantenimientos/frmMantusuarios.aspx" class="btn btn-primary mr-1">Crear usuario</a>
                        </div>
                    </div>

                    <div class="table-responsive">
                        <asp:GridView ID="gdvPreguntas" CssClass="table table-bordered table-condensed" OnPageIndexChanging="gdvPreguntas_PageIndexChanging" OnRowCommand="gdvPreguntas_RowCommand" OnRowDataBound="gdvPreguntas_RowDataBound" AllowPaging="true" AutoGenerateColumns="false" PageSize="5" runat="server">
                            <Columns>
                                <asp:TemplateField HeaderStyle-ForeColor="Black">
                                    <ItemTemplate>
                                        <asp:Button ID="btnEditar" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" runat="server" class="btn btn-large" Text="Editar" />
                                        <asp:Button ID="btnBorrar" CommandName="Borrar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CausesValidation="False" runat="server" class="btn btn-large" Text="Borrar" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="IdUsuario" HeaderText="Id" ReadOnly="True" SortExpression="IdUsuario" />
                                <asp:BoundField DataField="Usuario" HeaderText="Usuario">
                                </asp:BoundField>
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            </Columns>
                            <EmptyDataTemplate>No se han encontrado resultados</EmptyDataTemplate>
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </div>
    </div>

</asp:Content>

