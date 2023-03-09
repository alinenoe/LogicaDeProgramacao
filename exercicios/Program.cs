using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---dados do usuario---\n");
            String nome, endereco, telefone;
            
            Console.Write("digite o seu nome? ");
            nome = Console.ReadLine();

            Console.Write("digite o seu endereço? ");
            endereco = Console.ReadLine();

            Console.Write("digite o seu telefone? ");
            telefone = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\t\t----dados do usuario----\n");
           Console.WriteLine("nome: " + nome + "\nendereço: " + endereco + "\ntelefone: " + telefone);
            Console.ReadKey();

        }
    }
}
