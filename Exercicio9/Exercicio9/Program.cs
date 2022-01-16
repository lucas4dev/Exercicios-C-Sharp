using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 9. Faça um programa que verifique se um número é impar */
            int numero, resto;

            Console.WriteLine("Insira um número: ");

            numero = int.Parse(Console.ReadLine());
            resto = numero % 2; //resto da divisao de 2

            if (resto == 1)
                Console.WriteLine("O número digitado é impar");
            else
                Console.WriteLine("O número digitado é par");
        }
    }
}
