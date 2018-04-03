using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Vehiculo 
    {
        String tipo, patente;
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
