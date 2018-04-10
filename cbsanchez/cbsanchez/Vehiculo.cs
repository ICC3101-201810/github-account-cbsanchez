using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Vehiculo 
    {
        String tipo, patente; // los buses tienen sus tipos predeterminados, su tipo es bus liviano, bus normal, bus de lujo
        public Vehiculo(String mitipo, String mipatente) 
        {
            tipo = mitipo;
            patente = mipatente;
        }
        public String Gettipo()
        {
            return tipo;
        }
    }
}
