using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres e textos");

            char PrimeiraLetra = 'a';
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)65;
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char) (PrimeiraLetra + 1);
            Console.WriteLine(PrimeiraLetra);

            string titulo = "Curso de tecnologia " + 2022;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
 @" -.NET
 -Java
 -Javascript";
            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }
    }
}
