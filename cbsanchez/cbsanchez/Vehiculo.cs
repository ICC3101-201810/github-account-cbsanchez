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
        int precio;
        public Vehiculo(String mitipo, String mipatente, int miprecio) 
        {
            tipo = mitipo;
            patente = mipatente;
            precio = miprecio;
        }
        public String Gettipo()
        {
            return tipo;
        }
        public String Getpatente()
        {
            return patente;
        }
    }
}
