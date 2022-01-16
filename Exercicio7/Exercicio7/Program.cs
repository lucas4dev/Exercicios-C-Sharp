using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 7. Faça um programa que receba 2 valores e retorne o maior deles */
            int valor1, valor2;

            Console.WriteLine("Insira o valor 1");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 2");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
                Console.WriteLine("O maior valor é: " + valor1);
            else if (valor2 > valor1)
                Console.WriteLine("O maior valor é: " + valor2);
            else
                Console.WriteLine("Os dois valores são iguais " +valor1);
        }
            
    }
}
