using System;

namespace velydist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la distancia en KMS entre la ciudad de donde parte y la ciudad donde quiere llegar");
int distancia= int.Parse (Console.ReadLine());

Console.WriteLine ("ingrese la velocidad en KM/s de viaje");

int velocidad= int.Parse (Console.ReadLine());

int tiempodeviaje = distancia / velocidad;

Console.WriteLine ("su tiempo de viaje es de {0} horas aproximadamente", tiempodeviaje);






        }
    }
}
