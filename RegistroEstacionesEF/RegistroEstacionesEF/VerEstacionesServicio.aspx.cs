using RegistroEstacionesBD;
using RegistroEstacionesBD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroEstaciones
{
    public partial class VerEstacionesServicio : System.Web.UI.Page
    {
        EstacionServicioDAL estacionServicioDAL = new EstacionServicioDAL();

        //metodo cargar tabla
        private void CargarTabla(List<EstacionServicio> estacionesServicio)
        {
            estacionesServicioGrid.DataSource = estacionesServicio;
            estacionesServicioGrid.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                //Método cargar tabla
                CargarTabla(estacionServicioDAL.GetAll());

            }
        }

        protected void estacionesServicioGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                String idAEliminar = e.CommandArgument.ToString();
                estacionServicioDAL.Remove(idAEliminar);
                //Actulizar grilla
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }
    }
}