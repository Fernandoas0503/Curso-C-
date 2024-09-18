using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Curso_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código do Produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade: ");
            int Qtde = int.Parse(Console.ReadLine());

            string Desc_Produto;

            double total;

            if (codigo == 1 ) {
                Desc_Produto = "Cachorro Quente";
                total = Qtde * 4.00;
            }
            else if (codigo == 2) {
                Desc_Produto = "X-Salada";
                        total = Qtde * 4.50;  
            }
            else if (codigo == 3) {
                Desc_Produto = "X-Bacon";
                        total = Qtde * 5.0;
            }
            else if (codigo == 4) {
                Desc_Produto = "Torrada Sinples";
                total = Qtde * 2.0;
            }
            else {
                Desc_Produto = "Refrigerante";
                total = Qtde * 1.5;
            }
            Console.WriteLine("Produto: " + Desc_Produto.ToString());
            Console.WriteLine("  Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}