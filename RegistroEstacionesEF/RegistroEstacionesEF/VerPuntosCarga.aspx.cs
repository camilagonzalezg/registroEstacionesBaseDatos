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
                String idAEliminar = e.CommandArgument.ToString();
                puntoCargaDAL.Remove(idAEliminar);
                //Actulizar grilla
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        protected void tipoDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoSeleccionado = Convert.ToInt32(tipoDdl.SelectedValue);
            List<PuntoCarga> filtrada = puntoCargaDAL.GetAll(tipoSeleccionado);
            CargarTabla(filtrada);
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

        protected void puntosCargaGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            puntosCargaGrid.EditIndex = -1;
            CargarTabla(puntoCargaDAL.GetAll());

        }

        protected void puntosCargaGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            puntosCargaGrid.EditIndex = e.NewEditIndex;
            CargarTabla(puntoCargaDAL.GetAll());
        }

        protected void puntosCargaGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = puntosCargaGrid.Rows[e.RowIndex];

            int id = Convert.ToInt32(puntosCargaGrid.DataKeys[e.RowIndex].Values[0]);

            int tipo = Convert.ToInt32((fila.FindControl("txtTipo") as TextBox).Text);
            int capacidadMaxima = Convert.ToInt32((fila.FindControl("txtCapacidadMaxima") as TextBox).Text);
            //DateTime fechaVencimiento = ((fila.FindControl("txtFechaVencimiento") as TextBox).SelectedValue);

            //PuntoCarga p = puntoCargaDAL.GetAll(id);

            //p.Tipo = tipo;
            //p.CapacidadMaxima = capacidadMaxima;
           // p.FechaVencimiento = fechaVencimiento;
            

            //puntoCargaDAL.Update(p);

            puntosCargaGrid.EditIndex = -1;
            CargarTabla(puntoCargaDAL.GetAll());
        }

        protected void puntosCargaGrid_RowDataBoundEvent(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex == puntosCargaGrid.EditIndex)
            {
                DropDownList lista = e.Row.FindControl("txtfechaVencimiento") as DropDownList;
               // lista.DataSource = puntosCarga.GetAll();
                lista.DataBind();
            }
        }
    }
}