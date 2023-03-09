using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\n-----caixas----");
            int lar, pro, alt, volume;

            Console.Write("digite a largura da caixa:");
           lar=int.Parse(Console.ReadLine());


            Console.Write("digite a profundidade da caixa: ");
            pro= int.Parse(Console.ReadLine());

            Console.Write("digite a altura: ");
            alt = int.Parse(Console.ReadLine());

            volume = lar * pro * alt;

            Console.Clear();
            Console.WriteLine("\t\t----volume caixa----\n");
            Console.WriteLine("o volume da caixa retangular é: " + volume + "m");
            Console.ReadKey();
        }
    }
}
