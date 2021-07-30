<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RegistroEstaciones.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <main class="container-fluid mt-5">
        <div class="row">
            <div class="col-12 col-md-12 col-lg-12 text-center mx-auto">
                <h3>¡Hola! Bienvenido al Administrador de Estaciones de Servicio y Puntos de Carga.</h3>
                <br />
                <h5>¿Qué desea Administrar?</h5>
            </div>
        </div>
    </main>
    <main class="container-fluid mt-5">
        <div class="row">
            <div class="col-12 col-md-6 col-lg-4 text-center mx-auto">
                <div class="card">
                    <div class="card-header text-center">
                        <a href="RegistrarEstacionServicio.aspx">
                            <h6>Estaciones de Servicio</h6>
                        </a>
                    </div>
                    <div class="card-body">
                        <a title="EstacionServicio" href="RegistrarEstacionServicio.aspx">
                            <img src="img/estacionservicio.jpg" class="img-fluid" alt="EstacionServicio" />
                        </a>
                    </div>
                </div>
            </div>
            <div class="col-12 col-md-6 col-lg-4 text-center mx-auto">
                <div class="card">
                    <div class="card-header text-center">
                        <a href="RegistrarPuntosCarga.aspx">
                            <h6>Puntos de Carga</h6>
                        </a>
                    </div>
                    <div class="card-body">
                        <a title="PuntosCarga" href="RegistrarPuntosCarga.aspx">
                            <img src="img/puntocarga.jpg" class="img-fluid" alt="PuntosCarga" />
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </main>

</asp:Content>
