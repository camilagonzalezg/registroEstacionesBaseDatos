<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEstacionServicio.aspx.cs" Inherits="RegistroEstaciones.RegistrarEstacionServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-12 col-md-6 col-lg-4 mx-auto">
            <asp:Label ID="mensajeLbl1" runat="server" CssClass="text-success h3"></asp:Label>
        </div>
    </div>
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-4 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h5>Registro de Estaciones de Servicio</h5>
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="idTxt">Id (Formato: E-01, E-02, etc)</label>
                        <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="Debe ingresar solo números"
                            ValidateEmptyText="true" ControlToValidate="idTxt" OnServerValidate="idCV_ServerValidate"
                            CssClass="text-danger"></asp:CustomValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="RegionDdl">Region</label>
                        <asp:DropDownList runat="server" ID="RegionDdl" CssClass="form-select"></asp:DropDownList>
                    </div>

                    <div class="mb-3">
                        <label class="form-label" for="capacidadMaximaRb1">Capacidad Maxima</label>
                        <asp:RadioButtonList ID="capacidadMaximaRb1" runat="server">
                            <asp:ListItem Value="1" Selected="True" Text="1000W"></asp:ListItem>
                            <asp:ListItem Value="2" Selected="False" Text="2000W"></asp:ListItem>
                            <asp:ListItem Value="3" Selected="False" Text="3000W"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="card-footer d-grip gap-1">
                    <asp:Button ID="guardarBtn" runat="server" Text="Registrar" CssClass="btn btn-primary"
                        OnClick="guardarBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
