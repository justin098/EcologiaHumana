<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReporteUsuarios.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Reportes.frmReporteUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Reporte usuarios</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">

                    <div class="table-responsive">
                        <asp:LinkButton ID="lnkExport" runat="server" Text="Exportar a Excel" OnClick="lnkExport_Click"></asp:LinkButton>

                        <asp:GridView ID="gdvPreguntas" CssClass="table table-bordered table-condensed" OnPageIndexChanging="gdvPreguntas_PageIndexChanging" OnRowDataBound="gdvPreguntas_RowDataBound" AllowPaging="true" AutoGenerateColumns="false" PageSize="5" runat="server">
                            <Columns>
                                <asp:BoundField DataField="IdUsuario" HeaderText="Id" ReadOnly="True" SortExpression="IdUsuario" />
                                <asp:BoundField DataField="Usuario" HeaderText="Usuario"></asp:BoundField>
                                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario" />
                                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" />
                                <asp:BoundField DataField="Sede" HeaderText="Sede" />
                                <asp:BoundField DataField="Profesion" HeaderText="Profesion" />
                            </Columns>
                            <EmptyDataTemplate>No se han encontrado resultados</EmptyDataTemplate>
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
