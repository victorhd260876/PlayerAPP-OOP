namespace Hoteleria
{
    internal class Program
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
                 int opcion = int.Parse(Console.ReadLine());
                // Entra aqui -> 
                switch (opcion)
                {
                    case 1:
                        AgregarCliente(hoteleria);
                        break;
                    case 2:
                        //GestionProductos(sistema);
                        break;
                   case 0:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }



        }
    }
}
