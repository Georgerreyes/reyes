using System;

namespace Valor_Absoluto_de_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("Ingrese un numero positivo o negativo");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0) 
            Console.WriteLine("El numero es: " + numero + " y su valor absoluto es: " + Math.Abs(numero));
            else
                Console.WriteLine("El numero es " + numero);


            //George Reyes 
            

        }
    }
}
