using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Arriendo
    {
        Accesorio[] accesorios;
        DateTime fecha_inicio, fecha_termino;
        int precio;
        public Arriendo(Cliente cliente1, Sucursal sucursal, Vehiculo vehiculo1, Accesorio[] accesorios, DateTime mifecha_inicio, DateTime mifecha_termino, int miprecio )
        {
            fecha_inicio = mifecha_inicio;
            fecha_termino = mifecha_termino;
            precio = miprecio;
        }


    }
}
