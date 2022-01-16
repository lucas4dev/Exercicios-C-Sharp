using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 14. Refaça o exercício anterior usando o FOR */

            double num, soma = 0, media, /* i o "i" pode ser inteiro e declarado no for*/ numtotal = 5;
            for (int i = 0; i < numtotal; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° Valor");
                num = double.Parse(Console.ReadLine());
                soma = soma + num;
            }
            Console.WriteLine("A soma dos números é: " +soma);
            media = soma / numtotal;
            Console.WriteLine("A média dos números é: " + media);
        }
    }
}
