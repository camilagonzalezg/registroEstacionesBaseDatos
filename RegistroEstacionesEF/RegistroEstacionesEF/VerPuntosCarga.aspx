<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPuntosCarga.aspx.cs" Inherits="RegistroEstaciones.VerPuntosCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-6 col-md col-lg-4 mx-auto">
            <asp:DropDownList ID="tipoDdl" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="tipoDdl_SelectedIndexChanged" Enabled="false">
                <asp:ListItem Value="1" Selected="True" Text="Consumo"></asp:ListItem>
                <asp:ListItem Value="2" Selected="False" Text="Trafico"></asp:ListItem>
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
            OnRowCommand="puntosCargaGrid_RowCommand" CssClass="table table-hover"
            OnRowCancelingEdit="puntosCargaGrid_RowCancelingEdit"
            OnRowEditing="puntosCargaGrid_RowEditing"
            OnRowUpdating="puntosCargaGrid_RowUpdating"
            DataKeyNames="id"
            OnRowDataBound="puntosCargaGrid_RowDataBoundEvent"
            >
            <Columns>

                <asp:TemplateField HeaderText="ID de Punto de Carga">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtId" runat="server" Text='<%#Bind("Id") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Tipo">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Bind("Tipo") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTipo" runat="server" Text='<%#Bind("Tipo") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Capacidad Máxima">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Bind("CapacidadMaxima") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCapacidadMaxima" runat="server" Text='<%#Bind("CapacidadMaxima") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha Vencimiento">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%#Bind("FechaVencimiento") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFechaVencimiento" runat="server" Text='<%#Bind("FechaVencimiento") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>


                    <asp:CommandField ButtonType="Link" ShowEditButton="true" />


                <%--                
                <asp:BoundField HeaderText="ID de Punto de Carga" DataField="Id" />
                <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxima" />
                <asp:BoundField HeaderText="Fecha Vencimiento" DataField="FechaVencimiento" />
                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:Button runat="server" Text="Actualizar" CssClass="btn btn-danger"
                            CommandName="actualizar" CommandArgument='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                --%>

            </Columns>

        </asp:GridView>

    </div>

</asp:Content>
