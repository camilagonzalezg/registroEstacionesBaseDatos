<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarPuntosCarga.aspx.cs" Inherits="RegistroEstaciones.RegistrarPuntosCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-12 col-md-6 col-lg-4 mx-auto">
            <asp:Label ID="mensajeLbl2" runat="server" CssClass="text-success h3"></asp:Label>
        </div>
    </div>
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-4 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h5>Registro de Puntos de Carga</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="idTxt">Id (Formato: P-01, P-02, etc)</label>
                        <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="Debe ingresar formato requerido"
                            ValidateEmptyText="true" ControlToValidate="idTxt" OnServerValidate="idCV_ServerValidate"
                            CssClass="text-danger"></asp:CustomValidator>
                    </div>

                    <div class="mb-3">
                        <label class="form-label" for="tipoRb">Tipo</label>
                        <asp:RadioButtonList ID="tipoRb" runat="server">
                            <asp:ListItem Value="1" Selected="True" Text="Consumo"></asp:ListItem>
                            <asp:ListItem Value="2" Selected="False" Text="Trafico"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                    <div class="mb-3">
                        <label class="form-label" for="capacidadMaximaRb2">Capacidad Maxima</label>
                        <asp:RadioButtonList ID="capacidadMaximaRb2" runat="server">
                            <asp:ListItem Value="1" Selected="True" Text="1000W"></asp:ListItem>
                            <asp:ListItem Value="2" Selected="False" Text="2000W"></asp:ListItem>
                            <asp:ListItem Value="3" Selected="False" Text="3000W"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                    <div class="mb-3">
                        <label class="form-label" for="FechaVencimientoTxt">Fecha Vencimiento</label>
                        <asp:Calendar ID="FechaVencimientoTxt" runat="server" CssClass="form-control"></asp:Calendar>
                    </div>

                </div>
                <div class="card-footer d-grip gap-1">
                    <asp:Button ID="guardarBtn2" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="guardarBtn2_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
