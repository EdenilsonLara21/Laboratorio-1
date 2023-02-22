using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio_1
{

    internal class Program
    {
        static void Main(string[] args) 
        {
            string municipio = ""; string nombre;

            string edad;

            string departamento;

            while (true)
            {
                ///menu
                Console.WriteLine("**************Bienvenido**************");

                Console.WriteLine("para empezar vamos a solicitar sus datos:");
                Console.WriteLine("\n Ingrese su nombre:");
                nombre = Console.ReadLine();
     
                Console.WriteLine("ingrese su edad");
                edad = Console.ReadLine();

                Console.WriteLine("ingrese su departamento");
                departamento = Console.ReadLine();

                Console.WriteLine("ingrese su municipio");
                departamento = Console.ReadLine();

                Console.WriteLine(nombre +" " + edad + " " + departamento +" "+ municipio);

            }
            string Municipio()
            {
                Console.WriteLine("escriba el numero del departamento que escogio\n",
                    "1-Chalatenago 2-San salvador 3-La libertad 4- la union. 5-Santa Ana , 6-Sonsonate ");

                int depto = int.Parse(Console.ReadLine());

                switch (depto)
                {
                    case 1:
                        int datos = 0;
                        Console.WriteLine("1-Chalatenango \n 2-La palma \n 3- San ignacio \n 4- La nueva  \n 5-El paraiso \n," +
                            "6- Agua Caliente \n 7- Comalapa  \n 8- Concepcion Quezaltepeque \n");

                        Console.WriteLine("Escsriba su municipio");
                        datos = int.Parse(Console.ReadLine());
                        if (datos == 1)
                        {
                            municipio = "Chalatenango";
                        }
                        if (datos == 2)
                        {
                            municipio = "La palma";
                        }
                        if (datos == 3)
                        {
                            municipio = "San ignacio";
                        }
                        if (datos == 4)
                        {
                            municipio = "La nueva";
                        }
                        if (datos == 5)
                        {
                            municipio = "El paraiso";
                        }
                        if (datos == 6)
                        {
                            municipio = "Agua caliente";
                        }
                        if (datos == 7)
                        {
                            municipio = "Comalapa";
                        }
                        if (datos == 8)
                        {
                            municipio = "Concepcion quezaltepeque";
                        }
                        break;
                  
                }
                return Municipio();
            }
        }


        
    }
}

 