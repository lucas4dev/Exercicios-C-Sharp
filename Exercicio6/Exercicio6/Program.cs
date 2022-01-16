using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENUNCIADO 
            /* 6. Faça um programa que receba o valor do quilo de um produto e a quantidade de quilos do produto
             consumida calculando o valor final a ser pago. */
            double precoquilo, quantidadeconsumida, valorfinal;
            Console.WriteLine("Digite o preço do quilo do produto: ");
            precoquilo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de quilo consumida");
            quantidadeconsumida = double.Parse(Console.ReadLine());

           
            valorfinal = precoquilo * quantidadeconsumida;
            Console.WriteLine("O valor final a ser pago é: " +valorfinal);

        }
    }
}
