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
    public partial class VerPuntosCarga : System.Web.UI.Page
    {

        PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();

        //metodo cargar tabla
        private void CargarTabla(List<PuntoCarga> puntosCarga)
        {
            puntosCargaGrid.DataSource = puntosCarga;
            puntosCargaGrid.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Método cargar tabla
                CargarTabla(puntoCargaDAL.GetAll());

            }
        }

        protected void puntosCargaGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "actualizar")
            {
                
                //Actulizar grilla
                CargarTabla(puntoCargaDAL.GetAll());

            }
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int tipoSeleccionado = Convert.ToInt32(tipoDdl.SelectedValue);
            //List<PuntoCarga> filtrada = puntoCargaDAL.GetAll(tipoSeleccionado);
            //CargarTabla(filtrada);
        }

        protected void todosChk_CheckedChanged(object sender, EventArgs e)
        {
            //Cuando tipo está marcado, "mostrar todos" no lo estará
            tipoDdl.Enabled = !todosChk.Checked;

            //al presionar todos, que devuelva todos los datos
            if (todosChk.Checked)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }

        }

    }
}