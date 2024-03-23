namespace Contador.Contador
{
    public class Contador
    {
        // atributos de la clase contador 
        public double Valor { get; set; }

        // Constructor por defecto
        public Contador(){
            this.Valor = 0;
        }

        // Constructor con atributos
        public Contador(double Valor){
            this.Valor = Valor;
        }

        public void Consultar_Valor()
        {
            Console.WriteLine($"Valor actual: {Valor}");
        }

        public void Incrementar(double cantidad)
        {
            if (cantidad < Valor)
            {
                Console.WriteLine($"Error: No se puede ingresar un valor menor a {Valor}");
            }
            else
            {
                Valor += cantidad;
                Console.WriteLine($"Valor incrementado con exito. Nuevo Valor: {Valor}");
            }
        }

        public void Decrementar(double cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Error: La cantidad debe ser mayor que cero.");
            }
            else if (cantidad > Valor)
            {
                Console.WriteLine($"Error: No se puede ingresar un valor mayor a {Valor}");
            }
            else
            {
                Valor -= cantidad;
                Console.WriteLine($"Valor Decrementado con éxito. Nuevo Valor: {Valor}");
            }
        }

        public void Reiniciar()
        {
            Valor = 0;
            Console.WriteLine($"Contador reiniciado. Nuevo Valor: {Valor}");
        }
    }
}
