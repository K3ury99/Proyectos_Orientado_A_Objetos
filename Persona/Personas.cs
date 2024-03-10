// Clase personas
public class Personas{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool Casado { get; set; }
    public string Cedula { get; set; }

    // Constructor.

    public Personas(string nombre, string apellido, int edad, bool casado, string cedula)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Casado = casado;
        Cedula = cedula;
    }

    // 3 metodos con 3 profesiones diferentes.
    public void Profesion1()
    {
        Console.WriteLine($"Hola {Nombre} {Apellido}, su profesión será: Ingeniero en sistemas");
    }
    public void Profesion2()
    {
        Console.WriteLine($"Hola {Nombre} {Apellido}, su profesión será: Arquitecto");
    }
    public void Profesion3()
    {
        Console.WriteLine($"Hola {Nombre} {Apellido}, su profesión será: Doctor");
    }

    //Añade aleatoriamente las profesiones a las personas
    public void AsignarProfesionAleatoriamente(){
        // Generar un número aleatorio entre 1 y 3 (representando las tres profesiones)
        Random random = new Random();
        int numeroProfesion = random.Next(1, 4);

        // Asignar profesión basada en el número aleatorio
        switch (numeroProfesion)
        {
            case 0:
                break;
            case 1:
                Profesion1();
                break;
            case 2:
                Profesion2();
                break;
            case 3:
                Profesion3();
                break;
        }
    }
}
