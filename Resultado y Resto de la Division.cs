using System;

namespace Resultado_y_Resto_de_la_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*George Reyes, el dia 20 del mes de Mayo del año 2020*/
            
            Console.Write("Inserte el primer Numero: ");

            int N1=int.Parse(Console.ReadLine());

            Console.Write("Inserte el segundo Numero: ");

            int N2=int.Parse(Console.ReadLine());

            Console.Write("El resultado de la division es " + N1 / N2 + " y el resto es " + N1 % N2);

        }
    }
}
