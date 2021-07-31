using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstacionesBD
{
    public partial class PuntoCarga
    {

        public String TipoTxt
        {
            get
            {
                String texto = "";
                switch (Tipo)
                {
                    case 1: texto = "Consumo";
                        break;

                    case 2: texto = "Trafico";
                        break;
                }

                return texto;
            }
        }

    }
}
