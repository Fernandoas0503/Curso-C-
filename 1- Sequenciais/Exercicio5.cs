using System;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod_prod_1, cod_prod_2, num_prod_1, num_prod_2;
            double valor_prod, val_unit_1, val_unit_2;

            Console.WriteLine("Entre com o código da primeira peça: ");
            cod_prod_1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o código da segunda peça: ");
            cod_prod_2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o número de peças da primeira peça: ");
            num_prod_1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o número de peças da primeira peça: ");
            num_prod_2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor unitário da primeira peça: ");
            val_unit_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor unitário da primeira peça: ");
            val_unit_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor_prod = (num_prod_1 * val_unit_1) + (num_prod_2 * val_unit_2);

            Console.WriteLine("O Valor a ser pago é " + valor_prod.ToString("F2", CultureInfo.InvariantCulture));            

        }
    }
}