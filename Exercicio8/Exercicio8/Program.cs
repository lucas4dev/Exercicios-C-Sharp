using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 8. Faça um programa que receba 4 valores e retorne o menor deles. */
            int valor1, valor2, valor3, valor4;
            Console.WriteLine("Olá! Informe 4 valores e vamos mostrar qual o menor deles");

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            valor4 = int.Parse(Console.ReadLine());

            if (valor1 < valor2 && valor1 < valor3 && valor1 < valor4)
                Console.WriteLine("O menor valor é: " + valor1);
            else if (valor2 < valor3 && valor2 < valor4)
                Console.WriteLine("O menor valor é: " + valor2);
            else if (valor3 < valor4)
                Console.WriteLine("O menor valor é: " + valor3);
            else
                Console.WriteLine("O menor valor é: " + valor4);
        }
            

    }
}
