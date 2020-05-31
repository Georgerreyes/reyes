using System;

namespace Aprobado_o_Reprobado
{
    class Program
    {
        static void Main(string[] args)
        {

            double media;
            
            
            Console.WriteLine("Ingrese la Calificacion 1");
            int nota1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la Calificacion 2");
            int nota2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la Calificacion 3");
            int nota3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la Calificacion 4");
            int nota4 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese la Calificacion 5");
            int nota5 = int.Parse(Console.ReadLine());


                media = nota1 + nota2 + nota3 + nota4 + nota5 / 5;

            if (media >=70)
            {
                Console.WriteLine("Alumno Aprobado");
            }   else
            {
                Console.WriteLine("Alumnno Reprobado");
            }
                Console.ReadKey();

        }
    }
}               /*George Reyes*/
