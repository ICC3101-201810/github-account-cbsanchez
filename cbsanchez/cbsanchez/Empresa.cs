using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
     class Empresa : Cliente
    {
        String autorizacion, permiso_mpesada, permiso_bus; // permiso contiene valores de tipo si y no depensiendo de si tiene el permiso o no
        public Empresa(String nombre, String rut, String miautorizacion, String mipermiso, String mipermisob) : base(nombre, rut)
        {
            autorizacion = miautorizacion;
            permiso_mpesada = mipermiso;
            permiso_bus = mipermisob;
        }
        public bool VerificarVehiculo(Vehiculo vehiculo2)
        {
            if (autorizacion == vehiculo2.Gettipo())
            {
                if (vehiculo2.Gettipo() == "maquinaria pesada")
                {
                    if (permiso_mpesada == "si")
                    {
                        return true;
                    }
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
        public bool PedirAutorizacionMaquinaria(Empresa empresa1)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            if (numero >= 63) 
            {
                return false;
            }
            else 
            {
                empresa1.permiso_mpesada = "si";
                return true;
            }
        }
        public bool PedirAutorizacionBus(Empresa empresa)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 100);
            if (numero >= 80)
            {
                return false;
            }
            else
            {
                empresa.permiso_bus = "si";
                return true;
            }
        }
    }
}
