using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbsanchez
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("menu:");
                Console.WriteLine("1. crear sucursal");
                Console.WriteLine("2. arrendar auto");
                Console.WriteLine("3. cerrar");
                String p = Console.ReadLine();
                if ( p == "1")
                {
                    Console.WriteLine("ingrese la cantidad de vehiculos que puede tener su sucursal: ");
                    int capacidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la direccion de la sucursal: ");
                    String direccion = Console.ReadLine();
                    Console.WriteLine("ingrese la ciudad de la sucursal: ");
                    String ciudad = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(direccion, ciudad, capacidad );
                    for (int i = 0; i < capacidad; i++)
                    {
                        Console.WriteLine("ingrese el tipo de vehiculo a crear");
                        String tipo = Console.ReadLine();
                        Console.WriteLine("ingrese la patente del vehiculo a crear");
                        String patente = Console.ReadLine();
                        Vehiculo vehiculo1 = new Vehiculo(tipo, patente);
                        sucursal1.AgregarVehiculo(vehiculo1);
                    }
                    
                }
            }
            
        }
    }
}
