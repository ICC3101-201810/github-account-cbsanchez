using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Sucursal
    {
        String direccion, ciudad;
        int capacidad;
        Vehiculo[] vehiculos;
        Arriendo[] arriendos;
        public Sucursal( String midireccion, String miciudad, int micapacidad, Vehiculo[] vehiculos, Arriendo[] arriendos)
        {
            direccion = midireccion;
            ciudad = miciudad;
            capacidad = micapacidad;
            vehiculos = new Vehiculo[capacidad];
            arriendos = new Arriendo[capacidad];
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            int lugar = capacidad - vehiculos.Length;
            vehiculos[lugar] = vehiculo;
        }
        public void AgregarArriendo(Arriendo arriendo1)
        {
            int lugar = capacidad - arriendos.Length;
            arriendos[lugar] = arriendo1;
        }
    }
}
