using System;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_func, qtde_horas;
            double salario, val_hora;

            Console.WriteLine("Entre com o código do funcionário: ");
            id_func = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a quantidade de horas: ");
            qtde_horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor hora: ");            
            val_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = val_hora * qtde_horas;

            Console.WriteLine("O funcionário é = " + id_func);
            Console.WriteLine("E o salário é R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}