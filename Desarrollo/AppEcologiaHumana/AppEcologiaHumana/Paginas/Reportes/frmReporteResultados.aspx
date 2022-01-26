<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReporteResultados.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Reportes.frmReporteResultados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Usuarios</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <asp:LinkButton ID="lnkExport" runat="server" Text="Exportar a Excel" OnClick="lnkExport_Click"></asp:LinkButton>

                    <div class="table-responsive">
                        <asp:GridView ID="gdvPreguntas" CssClass="table table-bordered table-condensed" OnPageIndexChanging="gdvPreguntas_PageIndexChanging" AllowPaging="true" AutoGenerateColumns="false" PageSize="5" runat="server">
                            <Columns>
                                <asp:BoundField DataField="IdResultado" HeaderText="Id" ReadOnly="True" SortExpression="IdResultado" />
                                <asp:BoundField DataField="TotalResultado" HeaderText="TotalResultado"></asp:BoundField>
                                <asp:BoundField DataField="Dimension" HeaderText="Dimension" />
                                <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                            </Columns>
                            <EmptyDataTemplate>No se han encontrado resultados</EmptyDataTemplate>
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </div>
    </div>


</asp:Content>

