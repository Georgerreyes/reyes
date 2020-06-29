using System;

namespace Piedra_papel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Debes elegir piedra, papel o tijeras");
            string usuario = Console.ReadLine();

            Random ran = new Random();
            int computadora = ran.Next(3);

            if (computadora == 1)
            {
                if (usuario == "piedra")
                {
                    Console.WriteLine("Computadora elijio piedra");
                    Console.WriteLine("Es empate ");
                }
                else if (usuario == "papel") 
                {
                    Console.WriteLine("Computadora elijio papel");
                    Console.WriteLine("Es un empate ");

                }
                else if (usuario == "tijeras")
                {
                    Console.WriteLine("Computadora elijio tijeras");
                    Console.WriteLine("Es un empate ");
                }
                else
                {
                    Console.WriteLine("Debes elegir piedra, papel o tijeras");

                }

            }

            else if (computadora == 2)
            {
                if (usuario == "piedra")
                {
                    Console.WriteLine("Computadora elijio papel");
                    Console.WriteLine("Perdiste!");

                }
                else if (usuario == "papel")
                {
                    Console.WriteLine("Computadora elijio Tijeras");
                    Console.WriteLine("Perdiste, tijeras corta papel :/ ");

                }
                else if (usuario == "tijeras")
                {
                    Console.WriteLine("Computadora elijio Piedra");
                    Console.WriteLine("Perdiste, piedra rompe tijeras :/ ");
                }
                else
                {
                    Console.WriteLine("Debes elegir piedra, papel o tijeras");
                }
            }
            else if (computadora == 3)
            {
                if (usuario == "piedra")
                {
                    Console.WriteLine("Computadora elijio Tijeras");
                    Console.WriteLine("Ganaste, piedra rompe tijeras");

                }
                else if (usuario == "papel")
                {
                    Console.WriteLine("Computadora elijio Piedra");
                    Console.WriteLine("Ganaste, papel envuelve piedra!");

                }
                else if (usuario == "tijeras")
                {
                    Console.WriteLine("Computadora elijio papel");
                    Console.WriteLine("Ganaste, tijeras corta papel");

                }
                else
                {
                    Console.WriteLine("Debes elegir piedra, papel o tijeras");

                }

            }

            Console.ReadLine();
        }
    }
}
            

        
    

