using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();


            int idade = 16;
            int quantidadeDePessoas = 2;

            bool acompanhado = quantidadeDePessoas >= 2;

            if (idade >= 18 || acompanhado == true) // condição and : &&//
            {
                Console.WriteLine(" Acesso liberado...");
            }
            else
            {
                Console.WriteLine(" Acesso negado!");
            }
            Console.ReadLine();

        }
    }
}









