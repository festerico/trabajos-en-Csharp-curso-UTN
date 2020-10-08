using System;

namespace promdediodenotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
double promedio;

Console.WriteLine("ingrese 1ra Nota");
nota1=double.Parse(Console.ReadLine());
Console.WriteLine("ingrese 2da Nota");
nota2=double.Parse(Console.ReadLine());
Console.WriteLine("ingrese 3ra Nota");
nota3=double.Parse(Console.ReadLine());

promedio=(nota1 + nota2 + nota3)/3;

Console.WriteLine("el Promedio de notas es: " + promedio);
        }
    }
}
