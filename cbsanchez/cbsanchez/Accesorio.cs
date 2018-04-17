using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Accesorio
    {
        String tipo; // los accesorios se identifican con un tipo
        int precio;
        public Accesorio(String mitipo, int miprecio)
        {
            tipo =  mitipo;
            precio = miprecio;
        }
        public String Gettipo()
        {
            return tipo;
        }
   
      
    }
}
