using System;
using RegistroEstacionesBD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesBD.DAL
{
    public class RegionDAL
    {
        //lista estatica de regiones
        private static List<Region> regiones = new List<Region>()
        {

        new Region()
        {
            Nombre = "Arica y Parinacota",
            Codigo = "01"
        },

        new Region()
        {
            Nombre = "Tarapaca",
            Codigo = "02"
        },

        new Region()
        {
            Nombre = "Antofagasta",
            Codigo = "03"
        },

        new Region()
        {
            Nombre = "Atacama",
            Codigo = "04"
        },

        new Region()
        {
            Nombre = "Coquimbo",
            Codigo = "05"
        },

        new Region()
        {
            Nombre = "Valparaiso",
            Codigo = "06"
        },

        new Region()
        {
            Nombre = "Metropolitana",
            Codigo = "07"
        },

        new Region()
        {
            Nombre = "Libertador General Bernardo O'Higgins",
            Codigo = "08"
        },

        new Region()
        {
            Nombre = "Maule",
            Codigo = "09"
        },

        new Region()
        {
            Nombre = "Ñuble",
            Codigo = "010"
        },

        new Region()
        {
            Nombre = "Bío Bío",
            Codigo = "11"
        },

        new Region()
        {
            Nombre = "La Araucanía",
            Codigo = "12"
        },

        new Region()
        {
            Nombre = "Los Ríos",
            Codigo = "13"
        },

        new Region()
        {
            Nombre = "Los Lagos",
            Codigo = "14"
        },

        new Region()
        {
            Nombre = "Aysén del General Carlos Ibáñez del Campo",
            Codigo = "15"
        },

        new Region()
        {
            Nombre = "Magallanes y la Antártica Chilena",
            Codigo = "16"
        }
    };

        public List<Region> GetAll()
        {
            return regiones;
        }
    }

}