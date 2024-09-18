using System;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor1, Valor2, Soma;

            Console.WriteLine("Entre com o valor1: ");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor2: ");
            Valor2 = int.Parse(Console.ReadLine());

            Soma = Valor1 + Valor2;

            Console.WriteLine("A soma é: " + Soma);
        }
    }
}