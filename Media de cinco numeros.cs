using System;

namespace Media_de_cinco_numeros
{
    class Program
    {
        static void Main(string[] args)
        {



            double n1, n2, n3, n4, n5, media;

            Console.WriteLine("Escriba el Primer Numero para conseguir la media");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el Segundo Numero");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el Tercer Numero");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el Cuarto Numero");
            n4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el Quinto Numero");
            n5 = Convert.ToDouble(Console.ReadLine());

            media = n1 + n2 + n3 + n4 + n5 / 5;

            Console.WriteLine("La media de los numeros es: " + media);


        }
    }
}
