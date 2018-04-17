using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Arriendo
    {
        List<Accesorio> accesorios = new List<Accesorio>();
        DateTime fecha_inicio, fecha_termino;
        int precio;
        public Arriendo(Cliente cliente1, Vehiculo vehiculo1, DateTime mifecha_inicio, DateTime mifecha_termino, int miprecio )
        {
            fecha_inicio = mifecha_inicio;
            fecha_termino = mifecha_termino;
            precio = miprecio;
        }
        public void AgregarAccesorio(Accesorio accesorio)
        {
            accesorios.Add(accesorio);
        }


    }
}
