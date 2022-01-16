using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 13. Faça um programa que utilize a estrutura WHILE para ler 50 numeros e calcule e 
             exibe a média aritmética deles. */

            double num = 0, soma = 0, i = 0, numtotal = 2;

            while (i < numtotal)
            {
                Console.WriteLine("Insira o " + (i + 1)+ "° valor");
                num = double.Parse(Console.ReadLine());
                soma = soma + num;
                i++;
            }
            
            Console.WriteLine("A soma é " +soma);
            Console.WriteLine("A média é " +(soma / numtotal));
            

        }
    }
}
