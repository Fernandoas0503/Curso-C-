using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor: ");
            int X = int.Parse(Console.ReadLine());

            
            if (X % 2 == 0)
            { 
               Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
                

        }
    }
}