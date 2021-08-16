using System;

namespace tp2_bassi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Confeccionar las siguientes funciones:

// - Función Ordenar que reciba un vector y lo ordene de mayor a menor.
// - Función Promedio reciba un vector numérico y que devuelva el promedio de los elementos dentro del mismo.

//  Hacer un programa que pida números y cargue un vector de 10 elementos y 
//  muestre en pantalla los números ordenados y el promedio de los mismos
//  haciendo uso de las funciones antes desarrolladas.
        // int [] n= new int[ x]; declaracion de vector.
         
            

                  int [] vector = new int[10];
            
                  int i=0;
                   int a=0;
                  for ( i = 0; i < 10; i++)
            {
                 Console.WriteLine("ingrese un numero");
                 a= int.Parse(Console.ReadLine());

                  vector[i]= a; }
                  int [] funcion= Ordenar (vector);
                  int funcion1= Promedio (vector);
            
                  Console.WriteLine("presione una tecla para ver los valores ordenados de mayor a menor: ");
                 Console.ReadKey();
                for ( i = 0; i < 10; i++)
            {    Console.WriteLine("los numeros ordenados: " + funcion [i]);             
            
        }
                 Console.ReadKey();
                 Console.WriteLine ("Para saber el promedio de los valores ingresados presione una tecla.");
                 Console.ReadKey();
                  Console.WriteLine("El promedio de los valores ingresados es : " + funcion1 );
        //funcion ordenar:
                 static int [] Ordenar (int [] b){            
                   for( int y=0; y<10; y++){             
                     for (int k= y+1; k<10; k++){
                     int var;
                        if (b[y] > b[k]){
                         var= b[y];
                         b[y]=b[k];
                         b[k]=var;
          }
             }
             }
                  return b;
            }               

         //   funcion promedio
                static int Promedio (int [] b){
                    int prom=0;
                for(int i=0;i<10;i++){
                    int acu=0;
                    acu+= b[i];
                    prom=acu/100;}
                    return prom;

                }


    }
}
}