using System;

namespace Vota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estos son los candidatos Presidenciales");

                
            
            Console.WriteLine("1.  Ramon Lidar por el Partido Lince PL           (1970-2020)");
            Console.WriteLine("2.  Manuel Rosario por el Partido Rinoceronte PR  (1982-2020)");
            Console.WriteLine("3.  Leonel Fermin por el Partido Lobo Audaz LA    (1983-2020)");
            Console.WriteLine("4.  Nilda Perez por el Partido Las Gacelas        (1999-2020)");


            Random aleatorio = new Random();

            int ramon;
            int manuel;
            int leo;
            int nilda;


            ramon = aleatorio.Next(1, 251);
            manuel = aleatorio.Next(1, 251);
            leo = aleatorio.Next(1, 251);
            nilda = aleatorio.Next(1, 251);

       

            if (ramon >= 200)
            {
                Console.WriteLine("Ramon Lidar es el Ganador con un total de " + ramon);
            }
            else
            {
                Console.WriteLine("Ramon Lidar solo obtuvo un total de " + ramon + " votos");
            }

            if (manuel >= 200)
            {
                Console.WriteLine("Manuel Rosario es el Ganador con un total de " + manuel + "votos");
            }
            else
            {
                Console.WriteLine("Manuel Rosario solo obtuvo un total de " + manuel + " votos");
            }

            if (leo >= 200)
            {
                Console.WriteLine("Leonel Fermin es el Ganador con un total de " + leo );
            }

            else
            {
                Console.WriteLine("Leonel Fermin solo obtuvo un total de " + leo + " votos");
            }


            if (nilda >= 200)
            {
                Console.WriteLine(
                    "Nilda Perez es la Ganadora con un total de " + nilda);
            }
            
            else
            {
                Console.WriteLine("Nilda Perez solo obtuvo un total de " + nilda + " votos");
            }

           
           


        }
    }
}
