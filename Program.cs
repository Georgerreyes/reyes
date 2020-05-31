using System;

namespace Aplicacion_de_ITBI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Inserte el Precio del Producto");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ahora por favor digite el ITBIT");
            double itbit = double.Parse(Console.ReadLine());

            Console.WriteLine("El precio final es igual a: " +(precio + itbit));
        }
    }
}
