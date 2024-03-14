namespace Contactos.Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda manage = new Agenda();

            bool running = true;
            while (running)
            {
                Console.WriteLine("---Mi Agenda---");
                Console.WriteLine("---Bienvenido a tu lista de contactos");
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Ver Contactos");
                Console.WriteLine("3. Buscar Contactos");
                Console.WriteLine("4. Modificar Contacto");
                Console.WriteLine("5. Eliminar Contacto");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\nSaliendo del programa...\n");
                        return;
                    case 1:
                        manage.AddContact();
                        break;
                    case 2:
                        manage.ViewContacts();
                        break;
                    case 3:
                        manage.SearchContact();
                        break;
                    case 4:
                        manage.EditContact();
                        break;
                    case 5:
                        manage.DeleteContact();
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida...\n");
                        break;
                }
            }
        }
    }
}
//Creditos: Keury Ramirez. Matricula: 2023-1101.
