namespace Cuentas.Cuentas
{
    public class Cuenta
    {

        // atributos de la clase cuenta (datos que debe tener la clase "Cuenta")
        public double Saldo { get; set; }
        public string Propietario { get; set; }

        //Constructor por defecto
        public Cuenta()
        {
            this.Saldo = 0.0;
            this.Propietario = "Sin propietario";
        }

        //Constructor con parametros
        public Cuenta(double Saldo, string Propietario)
        {
            this.Saldo = Saldo;
            this.Propietario = Propietario;
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
                Console.WriteLine($"\nMonto retirado correctamente. Nuevo saldo {Saldo}");
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
        public void Transferencia(double cantidad, string propietario)
        {
        if (cantidad > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar la transferencia.");
        }
        else
        {
            Saldo -= cantidad;
            Propietario = propietario;
            Console.WriteLine($"\nTransferencia de {cantidad} realizada a {Propietario}. Nuevo saldo: {Saldo}");
        }
        }

    }
}