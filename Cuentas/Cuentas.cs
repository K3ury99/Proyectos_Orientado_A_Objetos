namespace Cuentas.Cuentas
{
    public class Cuenta
    {

        // parametros de la clase cuenta (datos que debe tener la clase "Cuenta")
        public double Saldo { get; set; }

        //Constructor por defecto
        public Cuenta()
        {
            this.Saldo = 0.0;
        }

        //Constructor con parametros
        public Cuenta(double Saldo)
        {
            this.Saldo = Saldo;
        }



        // Metodo: Consultar Saldo
        public double Consultar_saldo()
        {
            return Saldo;
        }

        // Metodo: Ingreso
        public void Ingreso(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($"\nMonto ingresado correctamente. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Erro, monto incorrecto.");
            }  
        }

        // Metodo: Retiro
        public void Retiro(double cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para retirar");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine("\nMonto retirado correctamente.");
            }  
        }

        // Metodo: Reintegro
        public void Reintegro(double cantidad)
        {
        if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar el reintegro.");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine($"Reintegro de {cantidad} realizado. Nuevo saldo: {Saldo}");
            }
        }

        // Metodo: Transferencia
        public void Transferencia(double cantidad)
        {
        if (cantidad > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar la transferencia.");
        }
        else
        {
            Saldo -= cantidad;
            Console.WriteLine($"Transferencia de {cantidad} realizada. Nuevo saldo: {Saldo}");
        }
        }

    }
}