using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;

namespace formularioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("alumno.txt");
            bool creation = true;
            while (creation)

            {
                Console.Write("operacion: 1-crear alumno 2-salir");
                string operacion = Console.ReadLine();
                int n = int.Parse(operacion);


                switch (n)
                {
                    case 1:
                        Console.WriteLine("Nombre");
                        string nombre = Console.ReadLine();
                        //int numero1Suma = int.Parse(number1Suma);

                        Console.WriteLine("Apellidos");
                        string Apellidos = Console.ReadLine();

                        Console.WriteLine("dni");
                        string dni = Console.ReadLine();

                        Console.WriteLine("edad");
                        string edad = Console.ReadLine();

                        fichero.WriteLine("Nombre {1}, Apellidos {2},  dni{3}, edad{4} ");
                        break;

                    case 2:
                        fichero.Close();
                        creation = false;
                        break;
                }
            }
        }
    }
}


