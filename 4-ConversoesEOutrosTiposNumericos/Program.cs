using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            Console.WriteLine(salario);

            //int = variável suporta valores de até 32 bits //
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //long= variável de 64 bits//
            long idade  = 130000000000000000;
            Console.WriteLine(idade);

            // short = até 16 bits //
            short quantidadeProdutos  = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();

        }
    }
}
