using System;

namespace Proyecto_final
{
    class Program
    {
        private static string nombre1;
        private static object int32;

        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES
            string nombre1, nombre2, nombre3;
            double cedula1, cedula2, cedula3;
            int clave1, clave2, clave3;
            string rol1, rol2, rol3;


            //ASIGNACION DE DATOS A LAS VARIABLES
            nombre1 = "Alfredo Jorge";
            nombre2 = "George Reyes";
            nombre3 = "Roberto Rijo";

            cedula1 = 40220253677;
            cedula2 = 40230353856;
            cedula3 = 40240213694;

            clave1 = 1212;
            clave2 = 1515;
            clave3 = 1919;

            rol1 = "SUPERVISOR";
            rol2 = "ADMINISTRADOR";
            rol3 = "VENDEDOR";


            //PETICION AL USUARIO
            Console.WriteLine("///////////////////////////////////////////INGRESE SU NUMERO DE CEDULA/////////////////////////////////////////////////");
            double usuario = double.Parse(Console.ReadLine());
            //PETICION DE CLAVE
            Console.WriteLine("////////////////////////////////////////////////INGRESE SU CLAVE//////////////////////////////////////////////////");
            int clave = int.Parse(Console.ReadLine());
            //LAS CONDICIONES 

           while (usuario != cedula1 && usuario != cedula2 && usuario != cedula3 || clave != clave1 && clave != clave2 && clave != clave3) {

            Console.WriteLine("--------------------------------DATOS INGRESADOS ERRONEAMENTE, INTENTE DE NUEVO-------------------------------------");

                //PETICION AL USUARIO DENTRO DEL BUCLE
            Console.WriteLine("------------------------------------VUELVA A INGRESE SU NUMERO DE CEDULA--------------------------------------------");
                usuario = double.Parse(Console.ReadLine());
                //PETICION DE CLAVE DENTRO DEL BUCLE
            Console.WriteLine("-----------------------------------------VUELVA A INGRESE SU CLAVE--------------------------------------------------");
                clave = int.Parse(Console.ReadLine());        
            }
            if (usuario == cedula1 || clave == clave1)
            {
                string primero = "******************ACABAS DE INGRESAR CON EL USUARIO:" + nombre1 + " Y TU ROL ES:" + rol1+ " 2010-2020**************";
                Console.WriteLine(primero);
            }
            else if (usuario == cedula2 || clave == clave2)
            {

                string segundo = "******************ACABAS DE INGRESAR CON EL USUARIO:" + nombre2 + " Y TU ROL ES:" + rol2+ " 2015-2020*************";
                Console.WriteLine(segundo);
            }

            else if (usuario == cedula3 || clave == clave3)
            {

                string tercero = "******************ACABAS DE INGRESAR CON EL USUARIO:" +nombre3 + " Y TU ROL ES:" + rol3+" 2012-2020***************";
                Console.WriteLine(tercero);
            }

            Console.ReadKey();
            
        }
    }
}
