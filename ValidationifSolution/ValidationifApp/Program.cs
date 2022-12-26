internal class Program
{
    private static void Main(string[] args)
    {
        int a = Leer("Ingrese Valor1: ");
        int b = Leer("Ingrese Valor2: ");
    
        Console.WriteLine ("El valor de a:  "+a);
        Console.WriteLine ("El valor de b:  "+b);
    }

    public static int Leer(string mensaje)
    {
        Console.WriteLine(mensaje);
        string numeroComoString = Console.ReadLine();
        int valorReal = 0;
        bool sePuedeConvertir=Int32.TryParse(numeroComoString, out valorReal);
        if(sePuedeConvertir)
        {
        return valorReal;
        }
    return 0;
    }
}