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
            List<Sucursal> sucursales = new List<Sucursal>();
            List<Accesorio> accesorios = new List<Accesorio>()
            {
                new Accesorio("GPS", 3000),
                new Accesorio("Rueda de respuesto", 20000),
                new Accesorio("Silla de niño", 10000),
                new Accesorio("Blutooth", 5000),
                new Accesorio("Cortinas para ventanas", 2000),
            };
            List<Empresa> empresas = new List<Empresa>();
            List<Organizacion> organizacion = new List<Organizacion>();
            List<Institucion> instituciones = new List<Institucion>();
            List<Persona> personas = new List<Persona>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            for (; ; )
            {
                Console.WriteLine("menu:"); 
                Console.WriteLine("1. crear sucursal");
                Console.WriteLine("2. crear vehiculo");
                Console.WriteLine("3. crear cliente");
                Console.WriteLine("4. arrendar vehiculo");
                Console.WriteLine("5. cerrar");
                String p = Console.ReadLine();
                if (p == "1")
                {
                    Console.WriteLine("ingrese la direccion de la sucursal: ");
                    String direccion = Console.ReadLine();
                    Console.WriteLine("ingrese la ciudad de la sucursal: ");
                    String ciudad = Console.ReadLine();
                    Console.WriteLine("ingrese el nombre de la sucursal: ");
                    String nombre = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(direccion, nombre, ciudad);
                    sucursales.Add(sucursal1);
                    continue;
                }
                if (p == "2")
                {
                    
                    Console.WriteLine("ingrese el tipo de vehiculo a crear");
                    String tipo = Console.ReadLine();
                    Console.WriteLine("ingrese la patente del vehiculo a crear");
                    String patente = Console.ReadLine();
                    Console.WriteLine("ingrese el nombre de la sucursal a la cual le asiganara este vehiculo");
                    String nombresuc = Console.ReadLine();
                    foreach (Sucursal sucursal1 in sucursales)
                    {
                        if (sucursal1.Getnombre() == nombresuc )
                        {
                            Vehiculo vehiculo1 = new Vehiculo(tipo, patente);
                            sucursal1.AgregarVehiculo(vehiculo1);
                            vehiculos.Add(vehiculo1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("no se ha podido crear el vehiculo ya que la sucursal ingresada no existe");

                        }
                    }
                    continue;
                    
                }
                if (p == "3")
                {
                    Console.WriteLine("ingrese el nombre del cliente:");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("ingrese el rut del cliente:");
                    String rut = Console.ReadLine();
                    Console.WriteLine("ingrese tipo de cliente:");
                    String tipo = Console.ReadLine();
                    if (tipo == "institucion")
                    {
                        Console.WriteLine("ingrese si tiene autorizacion (nombre de vehiculo que puede conducir):");
                        String autorizacion = Console.ReadLine();
                        Console.WriteLine("ingrese si tiene permiso para bus (si/no):");
                        String  permiso_bus = Console.ReadLine();
                        Institucion institucion1 = new Institucion(nombre, rut, autorizacion, permiso_bus);
                        instituciones.Add(institucion1);
                    }
                    if (tipo == "organizacion")
                    {
                        Console.WriteLine("ingrese si tiene autorizacion (nombre de vehiculo que puede conducir):");
                        String autorizacion = Console.ReadLine();
                        Console.WriteLine("ingrese si tiene permiso para bus (si/no):");
                        String permiso_bus = Console.ReadLine();
                        Organizacion organizacion1 = new Organizacion(nombre, rut, autorizacion, permiso_bus);
                        organizacion.Add(organizacion1);
                    }
                    if (tipo == "empresa")
                    {
                        Console.WriteLine("ingrese si tiene autorizacion (nombre de vehiculo que puede conducir):");
                        String autorizacion = Console.ReadLine();
                        Console.WriteLine("ingrese si tiene permiso para bus (si/no):");
                        String permiso_bus = Console.ReadLine();
                        Console.WriteLine("ingrese si tiene permiso para maquinaria pesada (si/no):");
                        String permiso_mpesada = Console.ReadLine();
                        Empresa empresa1 = new Empresa(nombre, rut, autorizacion, permiso_bus, permiso_mpesada);
                        empresas.Add(empresa1);
                    }
                    if (tipo == "persona")
                    {
                        Console.WriteLine("ingrese el tipo de licencia que posee (nombre de vehiculo que puede conducir):");
                        String tipolicencia = Console.ReadLine();
                        Console.WriteLine("ingrese el apellido de la persona:");
                        String apellido = Console.ReadLine();
                        Persona persona1 = new Persona(nombre, rut, apellido, tipolicencia);
                        personas.Add(persona1);
                    }
                    else { break; }
                    continue;
                    
                    
                }
                if (p == "4")
                {
                    Console.WriteLine("ingrese fecha de inicio del arriendo:");
                    DateTime fecha_inicio = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("ingrese fecha de termino del arriendo:");
                    DateTime fecha_termino = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre de la sucursal en que quiere arrendar un vehiculo:");
                    String nombre = Console.ReadLine();
                    Sucursal sucursal1 = sucursales.Where(suc => suc.Getnombre() == nombre).ToList().First();

                    //foreach (Sucursal sucursal1 in sucursales)
                    //{
                    //   if (sucursal1.Getnombre() == nombre)
                    //    {
                    //        sucursal = sucursal1;
                    //        break;
                    //    }
                    //    else { Console.WriteLine("sucursal no existe"); }
                    //}

                    Console.WriteLine("ingrese el rut del cliente:");
                    String rut = Console.ReadLine();
                    Console.WriteLine("ingrese el tipo de cliente que es (institucion, organizacion, empresa o persona): ");
                    String tipo2 = Console.ReadLine();
                    if (tipo2 == "institucion")
                    {
                        Cliente cliente1 = instituciones.Where(inst => inst.Getrut() == rut).ToList().First();
                    }
                    if (tipo2 == "organizacion")
                    {
                        Cliente cliente1 = organizacion.Where(org => org.Getrut() == rut).ToList().First();
                    }
                    if (tipo2 == "empresa")
                    {
                        Cliente cliente1 = empresas.Where(emp => emp.Getrut() == rut).ToList().First();
                    }
                    if (tipo2 == "persona")
                    {
                        Cliente cliente1 = personas.Where(per => per.Getrut() == rut).ToList().First();
                    }

                    Console.WriteLine("ingrese la patente del vehiculo que quiere arrendar:");
                    String patente = Console.ReadLine();
                    Vehiculo vehiculo1 = sucursal1.GetVehiculo(patente);
                    for (; ; )
                    {
                        Console.WriteLine("ingrese el tipo de accesorio que desea arrendar:");
                        String tipo = Console.ReadLine();
                        foreach (Accesorio accesorio1 in accesorios)
                        {
                            if (accesorio1.Gettipo() == tipo)
                            {
                                //arriendo1.AgregarAccesorio(accesorio1);
                            }
                        }
                        Console.WriteLine("¿quiere arrendar otro accesorio?");
                        String decision = Console.ReadLine();
                        if (decision == "si")
                        {
                            continue;
                        }
                        break;
                    }
                }
                if (p == "5")
                {
                    break;
                }
            }
            Console.ReadLine();    
        }
    }
}
