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
            string[] date = new string[100];
            string municipio = "";
            string nombre;
            string edad;
            string departamento;

            string Municipio()
            {
                while (true)
                {
                    
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
                            case 2:
                                int data2 = 0;
                                Console.WriteLine("1)aguilares.\n2)guazapa\n3)apopa\n4)el paisnal\n5)nejapa");
                                Console.WriteLine("digite su municipio");
                                data2 = int.Parse(Console.ReadLine());
                                if (data2 == 1)
                                {
                                    municipio = "aguilares";
                                }
                                if (data2 == 2)
                                {
                                    municipio = "guazapa";
                                }
                                if (data2 == 3)
                                {
                                    municipio = "apopa";
                                }
                                if (data2 == 4)
                                {
                                    municipio = "el paisnal";
                                }
                                if (data2 == 5)
                                {
                                    municipio = "nejapa";
                                }

                                break;





                            case 3:
                                int data3 = 0;
                                Console.WriteLine("1)antiguo cuscatlan.\n2)colon\n3)jicalapa\n4)santa tecla\n5)sacacoyo");
                                Console.WriteLine("digite su municipio");
                                data3 = int.Parse(Console.ReadLine());
                                if (data3 == 1)
                                {
                                    municipio = "antiguo cuscatlan";
                                }
                                if (data3 == 2)
                                {
                                    municipio = "colon";
                                }
                                if (data3 == 3)
                                {
                                    municipio = "jicalapa";
                                }
                                if (data3 == 4)
                                {
                                    municipio = "santa tecla";
                                }
                                if (data3 == 5)
                                {
                                    municipio = "sacacoyo";
                                }

                                break;

                            case 4:
                                int data4 = 0;
                                Console.WriteLine("1)bolivar.\n2)lislique\n3)nueva esparta\n4)san alejos\n5)anamoros");
                                Console.WriteLine("digite su municipio");
                                data4 = int.Parse(Console.ReadLine());
                                if (data4 == 1)
                                {
                                    municipio = "bolivar";
                                }
                                if (data4 == 2)
                                {
                                    municipio = "lislique";
                                }
                                if (data4 == 3)
                                {
                                    municipio = "nueva esparta";
                                }
                                if (data4 == 4)
                                {
                                    municipio = "san alejos";
                                }
                                if (data4 == 5)
                                {
                                    municipio = "anamoros";
                                }

                                break;




                            case 5:

                                int data5 = 0;
                                Console.WriteLine("1)acajutla \n2)armeria \n3)caluco \n4)san julian \n5)sonsonate \n 6) sonzacate");
                                Console.WriteLine("digite su municipio");
                                data5 = int.Parse(Console.ReadLine());
                                if (data5 == 1)
                                {
                                    municipio = "acajutla ";
                                }
                                if (data5 == 2)
                                {
                                    municipio = "armeria";
                                }
                                if (data5 == 3)
                                {
                                    municipio = "caluco";
                                }
                                if (data5 == 4)
                                {
                                    municipio = "san julian";
                                }
                                if (data5 == 5)
                                {
                                    municipio = "sonsonate";
                                }
                                if (data5 == 6)
                                {
                                    municipio = "sonzacate";
                                }

                                break;

                            case 6:
                                int data6 = 0;
                                Console.WriteLine("1)el congo.\n2)metapan\n3)santa rosa\n4)texistepeque\n5)san antonio pajonalo");
                                Console.WriteLine("digite su municipio");
                                data6 = int.Parse(Console.ReadLine());
                                if (data6 == 1)
                                {
                                    municipio = "el congo ";
                                }
                                if (data6 == 2)
                                {
                                    municipio = "metapan";
                                }
                                if (data6 == 3)
                                {
                                    municipio = "santa rosa";
                                }
                                if (data6 == 4)
                                {
                                    municipio = "texistepeque";
                                }
                                if (data6 == 5)
                                {
                                    municipio = "chalchuapa";
                                }

                                break;



                        }
                        return Municipio();
                    }

                    while (true)
                    {


                        Console.WriteLine("-----bienvenido--------\n se le pediran su datos para agregar su registro:");
                        Console.WriteLine("ingrese su numbre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("ingrese su edad");
                        edad = Console.ReadLine();
                        Console.WriteLine("ingrese su departamento");
                        departamento = Console.ReadLine();
                        Municipio();
                        string tre = Municipio();
                        int d = 0;
                        date[0] = nombre + " " + edad + " " + departamento + " " + tre;

                        Console.WriteLine(date[0]);
                    }

                }

            }


        }
    }
}

 