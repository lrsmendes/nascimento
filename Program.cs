using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(c)Raziel, 2022\n");
            Double idade, ano, nascimento;
            Console.Write("Digite seu ano de nascimento: ");
            idade = Convert.ToDouble(Console.ReadLine());
            ano = 2022;
            nascimento = ano - idade;
            Console.Write("\n");
            Console.WriteLine("Você tem " + nascimento + " anos de idade.");
            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
