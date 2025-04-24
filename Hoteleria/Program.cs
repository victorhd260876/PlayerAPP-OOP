namespace Hoteleria
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("=== Control de Hotelería ===\n");

            HoteleriaControl hoteleria = new HoteleriaControl();


            //menu principal
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Gestion de Clientes");
                Console.WriteLine("2. Gestion de Habitaciones");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\n Seleccione una opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());
                    // Entra aqui -> 
                    switch (opcion)
                    {
                        case 1:
                            GestionClientes(hoteleria);
                            break;
                        case 2:
                            //GestionProductos(hoteleria);
                            break;
                        case 0:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                    
            }



        }

        static void GestionClientes(HoteleriaControl hoteleria)
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.WriteLine("\nGestion de Clientes: ");
                Console.WriteLine("\nSeleccione una opcion: ");
                Console.WriteLine("1. Agregar un empleado");
                Console.WriteLine("2. Ver lista de empleados");
                Console.WriteLine("3. Ver empleado por Id");
                Console.WriteLine("4. Mostrar lista de tipos de empleados");
                Console.WriteLine("0. Regresar al menu principal");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCliente(hoteleria);
                        break;
                     case "0":
                        regresar = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }

        static void AgregarCliente(HoteleriaControl hoteleria)
        {
            Console.WriteLine("\nAgregar un nuevo Cliente: ");

            Console.WriteLine("Dni del empleado: ");
            string Dni = Console.ReadLine();

            Console.WriteLine("Tipo de Empleado: ");
            var tiposEmpleados = sistema.ObtenerTipoEmpleados();

 
        }

    }
}
