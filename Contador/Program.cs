namespace Contador.Contador
{
    class Program
    {
        public static Contador contador1 = new Contador();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("""
                Bienvenido al contador
                
                ¿Que desea hacer?
                
                1) Consultar el valor.
                2) Incrementar el valor.
                3) Decrementar el valor.
                4) Reiniciar el contador.
                0) Salir del contador.    
                """);

                Console.Write("---> ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        return;
                    case 1: //Consulta de Valor
                        contador1.Consultar_Valor();
                        break;
                    case 2: //Incremento
                        Console.Write("\nCuanto quiere incrementar?: ");
                        int incrementado = Convert.ToInt32(Console.ReadLine());
                        contador1.Incrementar(incrementado);
                        break;
                    case 3: //Decremento
                        Console.Write("\nCuanto quiere decrementar?: ");
                        int decrementado = Convert.ToInt32(Console.ReadLine());
                        contador1.Decrementar(decrementado);
                        break;
                    case 4: // Reiniciar
                        contador1.Reiniciar();
                        break;
                    default:
                        Console.WriteLine("Error, Introduzca un numero dentro del rango.");
                        break;
                }
            //Para volver a empezar
            Console.WriteLine("\n---¿Desea realizar otra operacion? (s/n): ");
            string ContinueOption = Console.ReadLine().ToLower();
            
            if(ContinueOption != "s")
            {
                Console.WriteLine("---Saliendo del Programa");
                break;
            }
            }
        }
    }
    
}