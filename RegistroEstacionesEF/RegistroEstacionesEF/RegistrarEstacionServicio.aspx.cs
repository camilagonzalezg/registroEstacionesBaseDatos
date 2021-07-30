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
    public partial class RegistrarEstacionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cargar la lista de regiones
            if (!IsPostBack)
            {
                List<Region> regiones = new RegionDAL().GetAll();
                RegionDdl.DataSource = regiones;
                RegionDdl.DataTextField = "Nombre";
                RegionDdl.DataValueField = "Codigo";
                RegionDdl.DataBind();
            }
        }

        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            //Primero, si pagina es válida
            if (Page.IsValid)
            {
                //crear objeto estacion servicio
                string id = idTxt.Text.Trim();
                int capacidadMaxima = Convert.ToInt32(capacidadMaximaRb1.SelectedValue);
                string region = RegionDdl.SelectedValue;

                EstacionServicio es = new EstacionServicio();
                es.Id = id;
                es.CapacidadMaxima = capacidadMaxima;
                es.Region = region;

                EstacionServicioDAL estacionServicioDAL = new EstacionServicioDAL();
                estacionServicioDAL.Add(es);
                //mensaje de exito en creacion de objeto
                mensajeLbl1.Text = "Estación de Servicio creada";
                //limpiar fields
                limpiar();

            }
            else
            {

            }
        }

        //metodo limpiar
        private void limpiar()
        {
            idTxt.Text = "";
            capacidadMaximaRb1.SelectedIndex = 0;
            RegionDdl.SelectedIndex = 0;
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

                //Caso ideal: E-XX
                //idArray[0] = E
                //idArray[1] = XX
                //idArray.Length == 2 

                if (idArray[0] != "E")
                {
                    //caso 3: primer digito ser "E"
                    idCV.ErrorMessage = "El primer digito debe ser 'E'";
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
