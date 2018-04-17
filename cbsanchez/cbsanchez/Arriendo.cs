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
        Vehiculo v1;
        Cliente cliente;
        //int precio;
        public Arriendo(Cliente cliente1, Vehiculo vehiculo1, DateTime mifecha_inicio, DateTime mifecha_termino, List<Accesorio> accesorios)
        {
            fecha_inicio = mifecha_inicio;
            fecha_termino = mifecha_termino;
            v1 = vehiculo1;
            cliente = cliente1;
            //precio = miprecio;
        }
        public void AgregarAccesorio(Accesorio accesorio)
        {
            accesorios.Add(accesorio);
        }
        public Vehiculo GetVehiculo()
        {
            return v1;
        }


    }
}
