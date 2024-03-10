class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Console.WriteLine("Bienvenido, vamos a ver cual es su profesion!\n");
        //Creando objetos de personas.
        Personas persona1 = new Personas("Carlos", "Perez", 45, true, "11111111");
        Personas persona2 = new Personas("Laura", "Gomez", 30, false, "22222222");
        Personas persona3 = new Personas("Francisco", "Rodriguez", 28, true, "33333333");
        Personas persona4 = new Personas("Carmen", "Hernandez", 35, false, "44444444");
        Personas persona5 = new Personas("Roberto", "Lara", 50, true, "55555555");
        Personas persona6 = new Personas("Marina", "Vargas", 28, false, "66666666");
        Personas persona7 = new Personas("Gabriel", "Diaz", 42, true, "77777777");
        Personas persona8 = new Personas("Sofia", "Fernandez", 29, false, "88888888");
        Personas persona9 = new Personas("Diego", "Lopez", 34, true, "99999999");
        Personas persona10 = new Personas("Leticia", "Gutierrez", 26, false, "10101010");

        //Añadiendo las profesiones manualmente
        // persona1.Profesion1();
        // persona2.Profesion2();
        // persona3.Profesion3();
        // persona4.Profesion1();
        // persona5.Profesion2();
        // persona6.Profesion3();
        // persona7.Profesion1();
        // persona8.Profesion2();
        // persona9.Profesion3();
        // persona10.Profesion1();

        //Añadiendo las profesiones aleatoriamente
        persona1.AsignarProfesionAleatoriamente();
        persona2.AsignarProfesionAleatoriamente();
        persona3.AsignarProfesionAleatoriamente();
        persona4.AsignarProfesionAleatoriamente();
        persona5.AsignarProfesionAleatoriamente();
        persona6.AsignarProfesionAleatoriamente();
        persona7.AsignarProfesionAleatoriamente();
        persona8.AsignarProfesionAleatoriamente();
        persona9.AsignarProfesionAleatoriamente();
        persona10.AsignarProfesionAleatoriamente();
    }
}
