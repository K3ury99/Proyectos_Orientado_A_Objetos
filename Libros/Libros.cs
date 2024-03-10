namespace Libros.Libros
{
    public class Libro
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }


        // Constructor por default
        public Libro()
        {
            this.Amount = 0;
            this.Name = "";
            this.Author = "";
            this.Year = "";
        }

        // Constructor con parametros
        public Libro(int Amount, string Name, string Author, string Year)
        {
            this.Amount = Amount;
            this.Name = Name;
            this.Author = Author;
            this.Year = Year;
        }

        public static Libro Agregar_Libro()
    {
        Console.Write("Ingrese el nombre del libro: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el autor del libro: ");
        string autor = Console.ReadLine();
        Console.Write("Ingrese el año del libro: ");
        string año = Console.ReadLine();

        return new Libro(1, nombre, autor, año);
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
                Console.WriteLine($"Nombre: {libro.Name} - Autor: {libro.Author} - Cantidad: {libro.Amount}");
            }
        }

        public static void Prestar_Libro(List<Libro> listaLibros, string nombreLibro, int cantidad)
        {
            Libro libroPrestado = listaLibros.Find(libro => libro.Name == nombreLibro);

            if (libroPrestado != null && libroPrestado.Amount >= cantidad && cantidad > 0)
            {
                libroPrestado.Amount -= cantidad;
                Console.WriteLine($"Libro prestado: {libroPrestado.Name} - Cantidad prestada: {cantidad}");
            }
            else
            {
                Console.WriteLine("No se puede prestar el libro. Libro no encontrado, cantidad insuficiente o cantidad negativa.");
            }
        }

        public static void Devolver_Libro(List<Libro> listaLibros, string nombreLibro, int cantidad)
        {
            Libro libroDevuelto = listaLibros.Find(libro => libro.Name == nombreLibro);

            if (libroDevuelto != null && cantidad > 0)
            {
                libroDevuelto.Amount += cantidad;
                Console.WriteLine($"Libro devuelto: {libroDevuelto.Name} - Cantidad devuelta: {cantidad}");
            }
            else
            {
                Console.WriteLine("No se puede devolver el libro. Libro no encontrado o cantidad negativa.");
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