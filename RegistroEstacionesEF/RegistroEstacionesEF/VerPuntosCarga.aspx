<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPuntosCarga.aspx.cs" Inherits="RegistroEstaciones.VerPuntosCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-6 col-md col-lg-4 mx-auto">
            <asp:DropDownList ID="tipoDdl" AutoPostBack="true" runat="server" 
                OnSelectedIndexChanged="tipoDdl_SelectedIndexChanged" Enabled="false">
                <asp:ListItem Value="1" Selected="True" Text="Consumo"></asp:ListItem>
                <asp:ListItem Value="2" Text="Trafico"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-6 col-md col-lg-4 mx-auto">
            <asp:CheckBox ID="todosChk" runat="server" AutoPostBack="true" Checked="true"
                Text="Mostrar todos" OnCheckedChanged="todosChk_CheckedChanged" />
        </div>
    </div>

    <div class="col-12 col-md-6 col-lg-4 mx-auto">

        <asp:GridView ID="puntosCargaGrid" runat="server" AutoGenerateColumns="false"
            EmptyDataText="¡Hola! No hay registros de Puntos de Carga creados aún."
            OnRowCommand="puntosCargaGrid_RowCommand" CssClass="table table-hover">
            <Columns>                                           
                <asp:BoundField HeaderText="ID de Punto de Carga" DataField="Id" />
                <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxima" />
                <asp:BoundField HeaderText="Fecha Vencimiento" DataField="FechaVencimiento" />
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Actualizar" CssClass="btn btn-danger"
                            CommandName="actualizar" CommandArgument='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField> 
            </Columns>

        </asp:GridView>

    </div>

</asp:Content>
