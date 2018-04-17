using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Organizacion : Cliente
    {
        String autorizacion, permiso_bus;
        public Organizacion(String nombre, String rut, String mipermisob, String miautorizacion) : base(nombre, rut)
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
                    if (permiso_bus == "si")
                    {
                        return true;
                    }
                    return false;
                }
                if (vehiculo2.Gettipo() == "bus normal")
                {
                    if (permiso_bus == "si")
                    {
                        return true;
                    }
                    return false;
                }
                if (vehiculo2.Gettipo() == "bus de lujo")
                {
                    if (permiso_bus == "si")
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
        public bool PedirAutorizacionBus(Organizacion organizacion)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            if (numero >= 35)
            {
                return false;
            }
            else
            {
                organizacion.permiso_bus = "si";
                return true;
            }
        }
    }
}