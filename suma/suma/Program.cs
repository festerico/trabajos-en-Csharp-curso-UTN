using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
    int numero1;
int numero2;
int resultado;
Console.WriteLine ("por favor ingrese el primer numero a sumar");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine ("por favor ingrese el siguiente numero a sumar");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine ("el resultado es");
resultado = numero1 + numero2;
Console.WriteLine(resultado);

        }
    }
}
