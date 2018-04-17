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
                new Accesorio("GPS", 3000, 6),
                new Accesorio("Rueda de respuesto", 20000, 3),
                new Accesorio("Silla de niño", 10000, 2),
                new Accesorio("Blutooth", 5000,10),
                new Accesorio("Cortinas para ventanas", 2000,20),
            };
            List<Empresa> empresas = new List<Empresa>();
            List<Organizacion> organizacion = new List<Organizacion>();
            List<Institucion> instituciones = new List<Institucion>();
            List<Persona> personas = new List<Persona>();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Arriendo> arriendos = new List<Arriendo>();
            for (; ; )
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("menu:"); 
                Console.WriteLine("1. crear sucursal");
                Console.WriteLine("2. crear vehiculo");
                Console.WriteLine("3. crear cliente");
                Console.WriteLine("4. arrendar vehiculo");
                Console.WriteLine("5. recibir arriendo");
                Console.WriteLine("6. cerrar");
                Console.BackgroundColor = ConsoleColor.Black;
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("se ha creado una sucursal con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    continue;
                }
                if (p == "2")
                {
                    
                    Console.WriteLine("ingrese el tipo de vehiculo a crear");
                    String tipo = Console.ReadLine();
                    Console.WriteLine("ingrese la patente del vehiculo a crear");
                    String patente = Console.ReadLine();
                    Console.WriteLine("ingrese el precio del vehiculo");
                    int precio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre de la sucursal a la cual le asiganara este vehiculo");
                    String nombresuc = Console.ReadLine();
                    foreach (Sucursal sucursal1 in sucursales)
                    {
                        if (sucursal1.Getnombre() == nombresuc )
                        {
                            Vehiculo vehiculo1 = new Vehiculo(tipo, patente, precio);
                            sucursal1.AgregarVehiculo(vehiculo1);
                            vehiculos.Add(vehiculo1);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("se ha creado un vehiculo con exito");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("no se ha podido crear el vehiculo ya que la sucursal ingresada no existe");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            Console.Beep();

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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("se ha creado un cliente con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                    }
                    if (tipo == "organizacion")
                    {
                        Console.WriteLine("ingrese si tiene autorizacion (nombre de vehiculo que puede conducir):");
                        String autorizacion = Console.ReadLine();
                        Console.WriteLine("ingrese si tiene permiso para bus (si/no):");
                        String permiso_bus = Console.ReadLine();
                        Organizacion organizacion1 = new Organizacion(nombre, rut, autorizacion, permiso_bus);
                        organizacion.Add(organizacion1);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("se ha creado un cliente con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("se ha creado un cliente con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                    }
                    if (tipo == "persona")
                    {
                        Console.WriteLine("ingrese el tipo de licencia que posee (nombre de vehiculo que puede conducir):");
                        String tipolicencia = Console.ReadLine();
                        Console.WriteLine("ingrese el apellido de la persona:");
                        String apellido = Console.ReadLine();
                        Persona persona1 = new Persona(nombre, rut, apellido, tipolicencia);
                        personas.Add(persona1);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("se ha creado un cliente con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("no se ha podido crear el cliente, el tipo de cliente no existe");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                        Console.Beep();
                    }
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
                    Console.WriteLine("ingrese el rut del cliente:");
                    String rut = Console.ReadLine();

                    Console.WriteLine("ingrese la patente del vehiculo que quiere arrendar:");
                    String patente = Console.ReadLine();
                    Vehiculo vehiculo1 = sucursal1.GetVehiculo(patente);

                    List<Accesorio> accesoriosAR = new List<Accesorio>();
                    for (; ; )
                    {
                        Console.WriteLine("ingrese el tipo de accesorio que desea arrendar:");
                        String tipo = Console.ReadLine();
                        foreach (Accesorio accesorio1 in accesorios)
                        {
                            if (accesorio1.Gettipo() == tipo)
                            {
                                if (accesorio1.Getdisponibilidad() > 0)
                                {
                                    accesoriosAR.Add(accesorio1);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("accesorio seleccionado");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int nueva_disp = accesorio1.Getdisponibilidad() - 1;
                                    accesorio1.CambiarDisponibilidad(nueva_disp);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("accesorio sin stock");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                
                            }
                        }
                        Console.WriteLine("¿quiere arrendar otro accesorio (si/no)?");
                        String decision = Console.ReadLine();
                        if (decision == "si")
                        {
                            continue;
                        }

                        break;
                    }

                    Console.WriteLine("ingrese el tipo de cliente que es (institucion, organizacion, empresa o persona): ");
                    String tipo2 = Console.ReadLine();
                    if (tipo2 == "institucion")
                    {
                        Institucion institucion1 = instituciones.Where(inst => inst.Getrut() == rut).ToList().First();
                        if (institucion1.VerificarVehiculo(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (institucion1.PedirAutorizacionBus(institucion1))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("permiso concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("permiso no concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }
                            
                            
                        }
                        Cliente cliente1 = instituciones.Where(inst => inst.Getrut() == rut).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente1, vehiculo1, fecha_inicio, fecha_termino, accesoriosAR);
                    }
                    if (tipo2 == "organizacion")
                    {
                        Organizacion organizacion1 = organizacion.Where(inst => inst.Getrut() == rut).ToList().First();
                        if (organizacion1.VerificarVehiculo(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (organizacion1.PedirAutorizacionBus(organizacion1))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("permiso concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("permiso no concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }


                        }
                        Cliente cliente1 = organizacion.Where(org => org.Getrut() == rut).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente1, vehiculo1, fecha_inicio, fecha_termino, accesoriosAR);
                    }
                    if (tipo2 == "empresa")
                    {
                        Empresa empresa1 = empresas.Where(inst => inst.Getrut() == rut).ToList().First();
                        if (empresa1.VerificarVehiculo(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (empresa1.PedirAutorizacionBus(empresa1))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("permiso concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (empresa1.PedirAutorizacionMaquinaria(empresa1))
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("permiso concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("permiso no concedido");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }


                        }
                        Cliente cliente1 = empresas.Where(emp => emp.Getrut() == rut).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente1, vehiculo1, fecha_inicio, fecha_termino, accesoriosAR);
                    }
                    if (tipo2 == "persona")
                    {
                        Persona Persona1 = personas.Where(inst => inst.Getrut() == rut).ToList().First();
                        if (Persona1.VerificarLicencia(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        { 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("permiso no concedido");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                            
                        }
                        Cliente cliente1 = personas.Where(per => per.Getrut() == rut).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente1, vehiculo1, fecha_inicio, fecha_termino, accesoriosAR);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("tipo de cliente no valido");
                        Console.WriteLine("no se ha podido completar el arriendo");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Beep();
                        Console.Beep();
                        break;
                    }

                   
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("se ha creado un arriendo con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                }
                if (p == "5")
                {
                    Console.WriteLine("ingrese la patente del vehiculo que quiere entregar:");
                    String patente = Console.ReadLine();
                    Console.WriteLine("ingrese el nombre de la sucursal a la cual quiere entregar el vehiculo:");
                    String nombre = Console.ReadLine();
                    Sucursal sucursal1 = sucursales.Where(suc => suc.Getnombre() == nombre).ToList().First();
                    Vehiculo vehiculo1 = sucursal1.GetVehiculo(patente);
                    Arriendo arriendo1 = sucursal1.Getarriendo(vehiculo1);
                    Arriendo arriendo = arriendos.Where(ar => ar == arriendo1).ToList().First(); 
                    arriendos.Remove(arriendo);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("se ha devuelto el vehiculo con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();


                }
                if (p == "6")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("se ha salido del programa");
                    break;
                }
            }
            Console.ReadLine();    
        }
    }
}
