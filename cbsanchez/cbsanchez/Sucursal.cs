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
        //int capacidad1, capacidad2;
        //Vehiculo[] vehiculos;
        //Arriendo[] arriendos;
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Arriendo> arriendos = new List<Arriendo>();
        public Sucursal(String midireccion, String miciudad, String minombre) // cada sucursal se identifica por un nombre unico
        {
            direccion = midireccion;
            ciudad = miciudad;
            nombre = minombre;
            //capacidad1 = micapacidad;
            //capacidad2 = micapacidad;
            //vehiculos = new Vehiculo[capacidad1];
            //arriendos = new Arriendo[capacidad2];
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }
        public void AgregarArriendo(Arriendo arriendo1)
        {
            arriendos.Add(arriendo1);
        }
        public Vehiculo GetVehiculo(String patente)
        {
            Vehiculo vehiculo = vehiculos.Where(vc => vc.Getpatente() == patente).ToList().First();
            return vehiculo;
        }
        public String Getnombre()
        {
            return nombre;
        }
    

    }
}
