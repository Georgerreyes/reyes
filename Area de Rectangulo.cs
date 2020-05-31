using System;

namespace Area_de_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor inserte la anchura de Rectangulo");

            int anchura = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora inserte la altura");

            int altura = int.Parse(Console.ReadLine());

            int area = anchura * altura;

            Console.WriteLine("El area del rectangulo es: " + area);
        }
    }
}
