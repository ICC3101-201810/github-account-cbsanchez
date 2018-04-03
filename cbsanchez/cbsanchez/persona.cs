using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Persona : Cliente
    {
        String tipolicencia, apellido;
        public Persona(String nombre, String miapellido, String rut, String mitipolicencia, Vehiculo vehiculo1): base(nombre, rut)
        {
            tipolicencia = mitipolicencia;
            apellido = miapellido;
        }
        public bool VerificarLicencia(Vehiculo vehiculo1)
        {
            if (tipolicencia == vehiculo1.Gettipo())
            {
                return false;
            }
            return true;
        }
    }
}
