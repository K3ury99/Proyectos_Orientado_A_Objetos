namespace Libros.Libros
{
    class Program
    {
        public static List<Libro> listaLibros = new List<Libro>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("""
                Bienvenido a su Librería.
                
                ¿Qué desea hacer?

                0) Salir del programa.
                1) Agregar un nuevo libro.
                2) Consultar información de un libro.
                3) Listar todos los libros.
                4) Prestar un libro.
                5) Devolver un libro.
                6) Eliminar un libro existente.       
                """);

                Console.Write("---> ");

                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        Console.Write("\nSaliendo del programa");
                        return;
                    case 1:
                        listaLibros.Add(Libro.Agregar_Libro());
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre del libro a consultar: ");
                        string nombreConsulta = Console.ReadLine();
                        Libro libroConsultado = Libro.Consultar_Libro(listaLibros, nombreConsulta);
                        if (libroConsultado != null)
                        {
                            Console.WriteLine($"Información del libro: Nombre: {libroConsultado.Name}, Autor: {libroConsultado.Author}, Cantidad: {libroConsultado.Amount}");
                        }
                        else
                        {
                            Console.WriteLine("Libro no encontrado.");
                        }
                        break;
                    case 3:
                        Libro.Listar_Libro(listaLibros);
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre del libro a prestar: ");
                        string nombrePrestamo = Console.ReadLine();

                        Console.Write("Ingrese el nombre de la persona a prestar: ");
                        string propietarioPrestamo = Console.ReadLine();
                        Libro.Prestar_Libro(listaLibros, nombrePrestamo, propietarioPrestamo);
                        break;
                    case 5:
                        Console.Write("Ingrese el nombre de la persona que va a devolver el libro: ");
                        string nombreDevolucion = Console.ReadLine();
                        Console.Write("Ingrese el nombre del libro a devolver: ");
                        string libroDevolucion = Console.ReadLine();
                        Libro.Devolver_Libro(listaLibros, libroDevolucion, nombreDevolucion);
                        break;
                    case 6:
                        Console.Write("Ingrese el nombre del libro a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        Libro.Eliminar_Libro(listaLibros, nombreEliminar);
                        break;
                    default:
                        Console.WriteLine("Introduzca una opción válida.");
                        break;
                }

                // Para volver a empezar
                Console.Write("\n---¿Desea realizar otra operación? (s/n): ");
                string continueOption = Console.ReadLine().ToLower();

                if (continueOption != "s")
                {
                    Console.WriteLine("---Saliendo del Programa");
                    break;
                }
            }
        }
    }
}
