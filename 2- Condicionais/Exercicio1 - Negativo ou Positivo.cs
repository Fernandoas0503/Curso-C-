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
            int N = int.Parse(Console.ReadLine());
            
            if (N < 0)
            { 
               Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não Negativo");
            }
                

        }
    }
}