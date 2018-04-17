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
        public Persona(String nombre, String miapellido, String rut, String mitipolicencia): base(nombre, rut)
        {
            tipolicencia = mitipolicencia;
            apellido = miapellido;
        }
       
        public bool VerificarLicencia(Vehiculo vehiculo1)
        {
            if (tipolicencia == vehiculo1.Gettipo())
            {
                if (vehiculo1.Gettipo() == "bus liviano")
                {
                    return false;
                }
                if (vehiculo1.Gettipo() == "bus normal")
                {
                    return false;
                }
                if (vehiculo1.Gettipo() == "bus de lujo")
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public String Gettipolicencia()
        {
            return tipolicencia;
        }
    }
}
