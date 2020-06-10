using System;

namespace Menor_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
                {
                    Console.WriteLine("El primer numero es menor: " + num1);
                }
            else
            {
                if (num2 < num1)
                {
                    Console.WriteLine("El segundo numero es menor: " + num2);
                }

                               
                
            }       //George Reyes
        }
    }
}
