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
                Console.WriteLine("2. crear accesorios");
                Console.WriteLine("3. arrendar auto");
                Console.WriteLine("4. cerrar");
                String p = Console.ReadLine();
                if (p == "1")
                {
                    Console.WriteLine("ingrese la cantidad de vehiculos que puede tener su sucursal: ");
                    int capacidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese la direccion de la sucursal: ");
                    String direccion = Console.ReadLine();
                    Console.WriteLine("ingrese la ciudad de la sucursal: ");
                    String ciudad = Console.ReadLine();
                    Console.WriteLine("ingrese el nombre de la sucursal: ");
                    String nombre = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(direccion, nombre, ciudad, capacidad);
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
                if (p == "2")
                {
                    for (; ; )
                    {
                        Console.WriteLine("ingrese el nombre del accesorio:");
                        String tipo = Console.ReadLine();
                        Console.WriteLine("ingrese el codigo del producto: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el precio del accesorio");
                        int precio = Convert.ToInt32(Console.ReadLine());
                        Accesorio accesorio1 = new Accesorio(tipo, codigo, precio);
                        Console.WriteLine("¿quiere crear otro accesorio?");
                        String decision = Console.ReadLine();
                        if (decision == "si")
                        {
                            continue;
                        }
                        break;
                    }
                } 
                
                if (p == "3")
                {
                    Console.WriteLine("ingrese el nombre de la sucursal en que quiere arrendar un vehiculo:");
                    String nombre = Console.ReadLine();
                    for (; ; )
                    {
                        Console.WriteLine("ingrese el codigo del accesorio que desea arrendar:");
                        String codigo = Console.ReadLine();
                        Console.WriteLine("¿quiere crear otro accesorio?");
                        String decision = Console.ReadLine();
                        if (decision == "si")
                        {
                            continue;
                        }
                        break;
                    }
                }
                if (p == "4")
                {
                    break;
                }
            }
            
        }
    }
}
