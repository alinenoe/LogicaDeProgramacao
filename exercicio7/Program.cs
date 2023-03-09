using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\n----pague suas dividas----");
            int prest, pago, valor;
            double divida, total;

            Console.WriteLine("digite a quantidade de prestações");
            prest = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor total da divida");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine("digite quantas prestaçoes voce pagou ");
            pago = int.Parse(Console.ReadLine());

            total = prest * valor;
            divida = pago - valor;

            Console.WriteLine("o valor total que deve pagar é " +total+ "total já pago " +divida+);
            Console.ReadKey();
        }
    }
}
