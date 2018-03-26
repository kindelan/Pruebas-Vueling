using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {

        static void Main(string[] args)
        {
             bool inside = true;
            while (inside)

            {

                Icalculadora icalculadora = new Calculadora();


                Console.Write("Por favor eilge tu operacion: 1-Suma 2-resta 3-Multiplicacion 4-division 5_Salir");
                string operacion = Console.ReadLine();
                int n = int.Parse(operacion);




                switch (n)
                {
                    case 1:
                        Console.WriteLine("elija numero 1");
                        string number1Suma = Console.ReadLine();
                        int numero1Suma = int.Parse(number1Suma);

                        Console.WriteLine("elija numero 2");
                        string number2Suma = Console.ReadLine();
                        int numero2Suma = int.Parse(number2Suma);

                        int resultSuma = icalculadora.Suma(numero1Suma, numero2Suma);
                        Console.WriteLine("El resultado de la suma es {0} ", resultSuma);
                        break;



                    case 2:

                        string number1Resta = Console.ReadLine();
                        int numero1Resta = int.Parse(number1Resta);

                        string number2Resta = Console.ReadLine();
                        int numero2Resta = int.Parse(number2Resta);

                        int resultResta = icalculadora.Resta(numero1Resta, numero2Resta);
                        Console.WriteLine("El resultado de la resta es " + resultResta);
                        break;

                    case 3:
                        Console.WriteLine("elija numero 1");
                        string number1Multiplic = Console.ReadLine();
                        int numero1Multiplica = int.Parse(number1Multiplic);

                        Console.WriteLine("elija numero 2");
                        string number2Multiplic = Console.ReadLine();
                        int numero2Multiplica = int.Parse(number2Multiplic);

                        int resultMultiplica = icalculadora.Suma(numero1Multiplica, numero2Multiplica);
                        Console.WriteLine("El resultado de la suma es {0} ", resultMultiplica);
                        break;

                    case 4:
                        Console.WriteLine("elija numero 1");
                        string number1Div = Console.ReadLine();
                        int numero1Div = int.Parse(number1Div);

                        Console.WriteLine("elija numero 2");
                        string number2Div = Console.ReadLine();
                        int numero2Div = int.Parse(number2Div);

                        int resultDiv = icalculadora.Suma(numero1Div, numero2Div);
                        Console.WriteLine("El resultado de la suma es {0} ", resultDiv);
                        break;

                    case 5:
                        inside = false;
                        break;
                }
            }
        }
    }
}

