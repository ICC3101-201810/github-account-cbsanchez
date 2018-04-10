using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Sucursal
    {
        String direccion, ciudad, nombre;
        int capacidad1, capacidad2;
        Vehiculo[] vehiculos;
        Arriendo[] arriendos;
        public Sucursal(String midireccion, String miciudad, String minombre, int micapacidad) // cada sucursal se identifica por un nombre unico
        {
            direccion = midireccion;
            ciudad = miciudad;
            nombre = minombre;
            capacidad1 = micapacidad;
            capacidad2 = micapacidad;
            vehiculos = new Vehiculo[capacidad1];
            arriendos = new Arriendo[capacidad2];
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            int lugar = vehiculos.Length - capacidad1;
            vehiculos[lugar] = vehiculo;
            capacidad1--;
        }
        public void AgregarArriendo(Arriendo arriendo1)
        {
            int lugar = arriendos.Length - capacidad2;
            arriendos[lugar] = arriendo1;
            capacidad2--;
        }
        public Array Getvehiculos()
        {
            return vehiculos;
        }
    }
}
