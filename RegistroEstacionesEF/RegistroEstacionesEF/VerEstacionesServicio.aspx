<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEstacionesServicio.aspx.cs" Inherits="RegistroEstaciones.VerEstacionesServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-12 col-md col-lg-4 mx-auto">

            <asp:GridView ID="estacionesServicioGrid" runat="server" AutoGenerateColumns="false"
                EmptyDataText="¡Hola! No hay registros de Estaciones de Servicio creados aún."
                CssClass="table table-hover" OnRowCommand="estacionesServicioGrid_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="ID de Estación Servicio" DataField="Id" />
                    <asp:BoundField HeaderText="Región" DataField="Region" />
                    <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxima" />
                    <asp:TemplateField HeaderText="Acción">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Eliminar Registro" CssClass="btn btn-danger"
                                CommandName="eliminar" CommandArgument='<%# Eval("Id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>

        </div>
    </div>
</asp:Content>
