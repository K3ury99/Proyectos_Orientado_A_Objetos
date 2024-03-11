public class Fraccion
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fraccion(int Numerador, int Denominador)
    {
        this.Numerador = Numerador;
        this.Denominador = Denominador;
    }

    public static Fraccion Sumar(Fraccion a, Fraccion b)
    {
        return new Fraccion(a.Numerador * b.Denominador + b.Numerador * a.Denominador, a.Denominador * b.Denominador);
    }

    public static Fraccion Restar(Fraccion a, Fraccion b)
    {
        return new Fraccion(a.Numerador * b.Denominador - b.Numerador * a.Denominador, a.Denominador * b.Denominador);
    }

    public static Fraccion Multiplicar(Fraccion a, Fraccion b)
    {
        return new Fraccion(a.Numerador * b.Numerador, a.Denominador * b.Denominador);
    }

    public static Fraccion Dividir(Fraccion a, Fraccion b)
    {
        return new Fraccion(a.Numerador * b.Denominador, a.Denominador * b.Numerador);
    }
}

