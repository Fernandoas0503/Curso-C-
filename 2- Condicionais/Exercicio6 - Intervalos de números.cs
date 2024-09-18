using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número: ", CultureInfo.InvariantCulture); //
            double num = double.Parse(Console.ReadLine());


            if (num < 0.0 || num > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (num <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (num <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }            
        }
    }
}