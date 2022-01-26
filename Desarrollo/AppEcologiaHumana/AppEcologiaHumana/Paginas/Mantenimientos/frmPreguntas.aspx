<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPreguntas.aspx.cs" Inherits="AppEcologiaHumana.Paginas.Mantenimientos.frmPreguntas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section full mt-2">
        <div class="section-title">Preguntas dimensiones</div>
        <div class="wide-block pt-2 pb-2">
            <div id="appCapsule">

                <div class="section mt-2 mb-5 p-3">
                    <div class="form-group basic">
                        <div class="input-wrapper">
                            <a href="<%= HttpContext.Current.Request.ApplicationPath %>Paginas/Mantenimientos/frmPreguntasDimension.aspx" class="btn btn-primary mr-1">Crear pregunta</a>
                        </div>
                    </div>
                    <div class="form-group basic">
                        <div class="form-group basic">
                            <div class="input-wrapper">
                                <label class="label" for="selectDimension">Dimensión</label>
                                <select runat="server" class="form-control" id="ddlDimension">
                                    <option value="1">Dimensión 1</option>
                                    <option value="2">Dimensión 2</option>
                                    <option value="3">Dimensión 3</option>
                                    <option value="4">Dimensión 4</option>
                                </select>
                            </div>
                        </div>
                        <div class="left">
                            <div class="input-wrapper">
                                <a href="#" class="btn btn-primary mr-1" runat="server" id="btnConsultar" onserverclick="btnConsultar_ServerClick">Consultar dimensión</a>
                            </div>
                        </div>
                    </div>
                    <div class="listed-detail mt-3">
                        <h3 class="text-center mt-2">Dimensión<pre runat="server" id="lblIdDim"></pre></h3>
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
                                <asp:BoundField DataField="IdPregunta" HeaderText="Id" ReadOnly="True" SortExpression="IdPregunta" />
                                <asp:BoundField DataField="Pregunta" HeaderText="Pregunta">
                                    <ItemStyle Width="35" Height="10" />
                                    <HeaderStyle Width="30px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                                <asp:BoundField DataField="Estilo" HeaderText="Estilo" />
                                <asp:BoundField DataField="Dimension" HeaderText="Dimension" />
                            </Columns>
                            <EmptyDataTemplate>No se han encontrado resultados</EmptyDataTemplate>
                        </asp:GridView>
                    </div>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
