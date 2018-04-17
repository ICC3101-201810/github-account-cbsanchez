using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Institucion : Cliente
    {
        String autorizacion, permiso_bus;
        public Institucion(String nombre, String rut, String miautorizacion, String mipermisob) : base(nombre, rut)
        {
            autorizacion = miautorizacion;
            permiso_bus = mipermisob;
        }
        public bool VerificarVehiculo(Vehiculo vehiculo2)
        {
            if (autorizacion == vehiculo2.Gettipo())
            {
                if (vehiculo2.Gettipo() == "maquinaria pesada")
                {
                    return false;
                }
                if (vehiculo2.Gettipo() == "bus liviano")
                {
                    return false;
                }
                if (vehiculo2.Gettipo() == "bus de lujo")
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public bool PedirAutorizacionBus(Institucion institucion)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            if (numero >= 58)
            {
                return false;
            }
            else
            {
                institucion.permiso_bus = "si";
                return true;
            }
        }
    }

}
