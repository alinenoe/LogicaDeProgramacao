using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\n ------continha------");
            int n1, n2, conta;
            Console.Write("digite um valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("digite um valor: ");
            n2 = int.Parse(Console.ReadLine());
            conta = n1 * n2;
            Console.Clear();
            Console.WriteLine("\t\t----dados do usuario----\n");
            Console.WriteLine("o resultado da multiplicação é " + conta);
            Console.ReadKey();


        }
    }
}
