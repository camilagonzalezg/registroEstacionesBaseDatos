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
    public partial class RegistrarPuntosCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardarBtn2_Click(object sender, EventArgs e)
        {
            //Primero, si pagina es válida
            if (Page.IsValid)
            {
                //crear objeto estacion servicio
                string id = idTxt.Text.Trim();
                int tipo = Convert.ToInt32(tipoRb.SelectedValue);
                int capacidadMaxima = Convert.ToInt32(capacidadMaximaRb2.SelectedValue);
                DateTime fechaVencimiento = FechaVencimientoTxt.SelectedDate;

                PuntoCarga pc = new PuntoCarga();
                pc.Id = id;
                pc.Tipo = tipo;
                pc.CapacidadMaxima = capacidadMaxima;
                pc.FechaVencimiento = fechaVencimiento;
            
                PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();
                puntoCargaDAL.Add(pc);
                //mensaje de exito en creacion de objeto
                mensajeLbl2.Text = "Punto de Carga creado";
                //limpiar fields
                limpiar();

            }
            else
            {

            }
        }

        private void limpiar()
        {
            idTxt.Text = "";
            tipoRb.SelectedIndex = 0;
            capacidadMaximaRb2.SelectedIndex = 0;
        }

        protected void idCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //validacion que id solo tenga numeros

            //primero, recurerar el valor del id
            String id = idTxt.Text.Trim();

            //caso 1: que id venga vacio
            if (id == string.Empty)
            {
                idCV.ErrorMessage = "Debe ingresar el id";
                args.IsValid = false;
            }
            else
            {
                //caso 2 id posee formato incorrecto
                String[] idArray = id.Split('-');

                //Caso ideal: P-XX
                //idArray[0] = P
                //idArray[1] = XX
                //idArray.Length == 2

                if (idArray[0]!= "P")
                {
                    //caso 3: primer digito ser "p"
                    idCV.ErrorMessage = "El primer digito debe ser 'P'";
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
                }

                if (idArray.Length == 2)
                {
                    if (idArray[1].Length != 2)
                    {
                        //caso 3: digito verificador debe tener largo 2
                        idCV.ErrorMessage = "El digito verificador debe tener 2 numeros";
                        args.IsValid = false;
                    }
                    else
                    {
                        args.IsValid = true;
                    }
                }
                else
                {
                    idCV.ErrorMessage = "ID no posee el formato correcto";
                    args.IsValid = false;
                }

            }
        }
    }
    
}