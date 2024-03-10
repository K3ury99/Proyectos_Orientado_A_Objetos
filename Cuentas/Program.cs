namespace Cuentas.Cuentas //Se pone el nomnbre de la carpeta y el proyecto unido por un punto (.)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("""
                Bienvenido a su banco!

                ¿Que desea hacer con su cuenta?
                1) Consultar saldo
                2) Ingresar dinero
                3) Retirar dinero
                4) Reintegrar
                5) Transferir
                0) Salir del programa       
                """);

                Console.Write("---> ");

                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        return;
                    case 1:
                        Cuenta cuenta1 = new Cuenta();
                        cuenta1.Consultar_saldo();
                        Console.WriteLine("\nSu saldo actual es: " + cuenta1.Saldo);
                        break;
                    case 2:
                        Cuenta cuenta2 = new Cuenta();
                        Console.Write("Introduzca la cantidad a ingresar: ");
                        double ingresado = Convert.ToDouble(Console.ReadLine());
                        cuenta2.Ingreso(ingresado);
                        break;
                    case 3:
                        Cuenta cuenta3 = new Cuenta();
                        Console.Write("Introduzca la cantidad a retirar: ");
                        double retirado = Convert.ToDouble(Console.ReadLine());
                        cuenta3.Retiro(retirado);
                        break;
                    case 4:
                        Cuenta cuenta4 = new Cuenta();
                        Console.Write("Ingrese la cantidad que va a reintegrar: ");
                        double reintegrado = Convert.ToDouble(Console.ReadLine());
                        cuenta4.Reintegro(reintegrado);
                        break;
                    case 5:
                        Cuenta cuenta5 = new Cuenta();
                        Console.Write("Ingrese la cantidad que desea transferir: ");
                        double transferido = Convert.ToDouble(Console.ReadLine());
                        cuenta5.Transferencia(transferido);
                        break;
                    default:
                        Console.WriteLine("Opción no válida...");
                        break;
                }

            // //Para volver a empezar
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



