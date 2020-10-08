using System;

namespace sueldycomi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingresar el total facturado por el empleado");
            double totfact =  double.Parse(Console.ReadLine());
            double comision= totfact * 0.05;
            double sueldofinal = comision + 15000;

Console.WriteLine (" el sueldo total a cobrar por el empleado es {o}", sueldofinal);





        }
    }
}
