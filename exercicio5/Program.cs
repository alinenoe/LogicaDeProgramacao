using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\n----consumo de combustivel----");
            int km, litros, quantidade;

            Console.Write("digite a quantidade de combustivel colocada :");
            litros = int.Parse(Console.ReadLine());

            Console.Write("digite quantos km percorreu :");
            km = int.Parse(Console.ReadLine());

            quantidade = litros / km;

            Console.Clear();
            Console.WriteLine("\t\t----km por litros----\n");
            Console.WriteLine("o seu carro esta fazendo " + quantidade + " km por litro");
            Console.ReadKey();
        }
    }
}
