using System;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, dif;

            Console.WriteLine("Entre com o valor A: ");
            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor B: ");
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor C: ");
            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor D: ");
            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dif = (A * B) - (C * D);

            Console.WriteLine("A diferença é = " + dif.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}