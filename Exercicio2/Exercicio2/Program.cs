using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 2 Crie um algoritmo que após ler dois números inteiros apresenta a sua soma */
            int numero1, numero2;
            Console.WriteLine("Insira 2 números para ser feito a soma:");
            numero1 = int.Parse(Console.ReadLine()); // colocamos desta forma (int.Pparse), pois o readline sozinho le apenas string
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma destes 2 numeros é: " + (numero1 + numero2));
            Console.WriteLine("A soma de " + numero1 + " com " + numero2 + " é " + (numero1 + numero2));
        }
    }
}
