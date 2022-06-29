using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade");
            int idade = 16; //Como adicionar entrada para concatenar com uma string?//
            int quantidadeDePessoas = 1;

            if (idade >= 18)
            {
                Console.WriteLine(nome + " tem mais de 18 anos. Acesso liberado...");

            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine(nome + " não possui mais de 18 anos, mas está acompanhado. Acesso liberado...");
                }
                else
                {
                    Console.WriteLine(nome + " não possui 18 anos. Acesso negado!");
                }


            }



            Console.ReadLine();
        }
    }
}
