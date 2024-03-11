namespace Libros.Libros
{
    public class Libro
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Propietario { get; set; }

        // Constructor por default
        public Libro()
        {
            this.Amount = 0;
            this.Name = "";
            this.Author = "";
            this.Year = "";
            this.Propietario = "";
        }

        // Constructor con parametros
        public Libro(int Amount, string Name, string Author, string Year, string Propietario)
        {
            this.Amount = Amount;
            this.Name = Name;
            this.Author = Author;
            this.Year = Year;
            this.Propietario = Propietario;
        }

        public static Libro Agregar_Libro()
        {
            Console.Write("Ingrese el nombre del libro: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese el año del libro: ");
            string año = Console.ReadLine();
            Console.Write("Ingrese el propietario del libro: ");
            string propietario = Console.ReadLine();

            return new Libro(1, nombre, autor, año, propietario);
        }

        public static Libro Consultar_Libro(List<Libro> listaLibros, string nombreLibro)
        {
            return listaLibros.Find(libro => libro.Name == nombreLibro);
        }

        public static void Listar_Libro(List<Libro> listaLibros)
        {
            Console.WriteLine("Lista de libros:");
            foreach (var libro in listaLibros)
            {
                Console.WriteLine($"Nombre: {libro.Name} - Autor: {libro.Author} - Año: {libro.Year} Cantidad: {libro.Amount}");
            }
        }

        public static void Prestar_Libro(List<Libro> listaLibros, string nombreLibro, string propietarioLibro)
        {
            Libro libroPrestado = listaLibros.Find(libro => libro.Name == nombreLibro);

            if (libroPrestado != null && string.IsNullOrEmpty(libroPrestado.Propietario))
            {
                libroPrestado.Propietario = propietarioLibro;
                Console.WriteLine($"Libro prestado: {libroPrestado.Name} - Prestado a: {libroPrestado.Propietario}");
            }
            else if (libroPrestado != null && !string.IsNullOrEmpty(libroPrestado.Propietario))
            {
                Console.WriteLine($"El libro '{libroPrestado.Name}' ya está prestado a '{libroPrestado.Propietario}'.");
            }
            else
            {
                Console.WriteLine($"No se puede prestar el libro '{nombreLibro}'. Libro no encontrado o no está disponible para prestar.");
            }
        }

        public static void Devolver_Libro(List<Libro> listaLibros, string nombreLibro, string propietarioLibro)
        {
            Libro libroDevuelto = listaLibros.Find(libro => libro.Name == nombreLibro);

            if (libroDevuelto != null && libroDevuelto.Propietario == propietarioLibro)
            {
                libroDevuelto.Propietario = "";
                Console.WriteLine($"Libro devuelto: {libroDevuelto.Name}.");
            }
            else
            {
                Console.WriteLine("No se puede devolver el libro. Libro no encontrado o no coincide con el propietario.");
            }
        }

        public static void Eliminar_Libro(List<Libro> listaLibros, string nombreLibro)
        {
            Libro libroEliminar = listaLibros.Find(libro => libro.Name == nombreLibro);
            if (libroEliminar != null)
            {
                listaLibros.Remove(libroEliminar);
                Console.WriteLine($"Libro eliminado: {libroEliminar.Name}");
            }
            else
            {
                Console.WriteLine("No se puede eliminar el libro. Libro no encontrado.");
            }
        }
    }
}
