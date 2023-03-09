using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\n------media aluno-----");
            int media, id1, id2, id3, id4, id5;

            Console.Write("idade do aluno: ");
            id1 = int.Parse(Console.ReadLine());

            Console.Write("idade do aluno: ");
            id2 = int.Parse(Console.ReadLine());

            Console.Write("idade do aluno: ");
            id3 = int.Parse(Console.ReadLine());

            Console.Write("idade do aluno: ");
            id4 = int.Parse(Console.ReadLine());

            Console.Write("idade do aluno: ");
            id5 = int.Parse(Console.ReadLine());

            media = (id1 + id2 + id3 + id4 + id5) / 5;

                 Console.Clear();
            Console.WriteLine("\t\t----media aluno----\n");
            Console.WriteLine("a media é: " + media);
            Console.ReadKey();
        }
    }
}
