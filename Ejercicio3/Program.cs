using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Escribir un método que acepte dos strings y devuelva el string con más caracteres. Si ambos tienen la misma cantidad de caracteres, devolver cualquiera de los dos.


namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Escriba una palabra : ");
                    string palabra1 = Console.ReadLine();
                    Console.WriteLine("Escriba otra  palabra : ");
                    string palabra2 = Console.ReadLine();

                    if (palabra1.Length>palabra2.Length)
                    {
                        Console.WriteLine("La palabra "+palabra1 + " tiene más caracteres que la palabra " + palabra2);

                    }
                    else
                    {
                        Console.WriteLine("La palabra " + palabra2 + " tiene más caracteres que la palabra " + palabra1);

                    }

                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escibre algo bien XD ");
                }
            }


            Console.Read();
        }
    }


    }

