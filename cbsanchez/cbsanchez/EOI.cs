using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class EOI : Cliente
    {
        String autorizacion;
        public EOI(String nombre, String rut, String miautorizacion, Vehiculo vehiculo2) : base(nombre, rut)
        {
            autorizacion = miautorizacion;
        }
        public bool VerificarAutorizacion(Vehiculo vehiculo2)
        {
            if (autorizacion == vehiculo2.Gettipo())
            {
                return false;
            }
            return true;
        }
    }
}
