namespace Fracciones.Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Fraccion fraccion1 = new Fraccion(2, 3);
            Fraccion fraccion2 = new Fraccion(1, 4);

            Console.WriteLine("""
            Bienvenido a tu calculadora de fracciones
            
            No perdamos mucho tiempo...
            
            1) Hacer todo (Suma, Resta, Multiplicacion, Division)
            0) Salir del programa
            """);

            Console.Write("---> ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Console.Write("Saliendo del programa...");
                    break;

                case 1:
                    Console.Write("\nIntroduce 2 numeros separados para la primera fraccion (ejemplo: 3 4): ");
                    string[] entradaFraccion1 = Console.ReadLine().Split(' ');
                    if (entradaFraccion1.Length == 2)
                    {
                        fraccion1.Numerador = Convert.ToInt32(entradaFraccion1[0]);
                        fraccion1.Denominador = Convert.ToInt32(entradaFraccion1[1]);

                        Console.Write("Introduce 2 numeros separados para la segunda fraccion (ejemplo: 1 2): ");
                        string[] entradaFraccion2 = Console.ReadLine().Split(' ');
                        if (entradaFraccion2.Length == 2)
                        {
                            fraccion2.Numerador = Convert.ToInt32(entradaFraccion2[0]);
                            fraccion2.Denominador = Convert.ToInt32(entradaFraccion2[1]);

                            RealizarOperaciones(fraccion1, fraccion2);
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida para la segunda fracción.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida para la primera fracción.");
                    }
                    break;

                default:
                    Console.WriteLine("Introduce 0 o 1.");
                    break;
            }
        }

        static void RealizarOperaciones(Fraccion fraccion1, Fraccion fraccion2)
        {
            Fraccion resultadoSuma = Fraccion.Sumar(fraccion1, fraccion2);
            Fraccion resultadoResta = Fraccion.Restar(fraccion1, fraccion2);
            Fraccion resultadoMultiplicacion = Fraccion.Multiplicar(fraccion1, fraccion2);
            Fraccion resultadoDivision = Fraccion.Dividir(fraccion1, fraccion2);

            Console.WriteLine($"\nResultado de la suma: {resultadoSuma.Numerador}/{resultadoSuma.Denominador}");
            Console.WriteLine($"Resultado de la resta: {resultadoResta.Numerador}/{resultadoResta.Denominador}");
            Console.WriteLine($"Resultado de la multiplicación: {resultadoMultiplicacion.Numerador}/{resultadoMultiplicacion.Denominador}");
            Console.WriteLine($"Resultado de la división: {resultadoDivision.Numerador}/{resultadoDivision.Denominador}\n");
        }
    }
}
