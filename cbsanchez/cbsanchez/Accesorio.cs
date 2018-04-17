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
        int precio, disponibilidad;
        public Accesorio(String mitipo, int miprecio, int midisponibilidad)
        {
            tipo =  mitipo;
            precio = miprecio;
            disponibilidad = midisponibilidad;
        }
        public String Gettipo()
        {
            return tipo;
        }
        public int Getprecio()
        {
            return precio;
        }
        public int Getdisponibilidad()
        {
            return disponibilidad;
        }
        public void CambiarDisponibilidad(int nuevadisp)
        {
            disponibilidad = nuevadisp;
        }




    }
}
