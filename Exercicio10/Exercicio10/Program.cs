using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 10. Faça um programa que receba 3 valores que representarão os lados de um triângulo e 
               verifique se os valores formam um triângulo e classifique esse triângulo como:
            a. Equilátero (3 lados iguais);
            b. Isósceles (2 lados iguais);
            c. Escaleno (3 lados diferentes).

            De notar que para formar um triângulo:
            a. Nenhum dos lados pode ser igual a zero;
            b. Um lado não pode ser maior do que a soma dos outros dois; */

            int v1, v2, v3;

            Console.WriteLine("Digite o primeiro valor");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            v3 = int.Parse(Console.ReadLine());

           if (v1 == 0 || v2 == 0 || v3 == 0)
                Console.WriteLine("Nenhum dos lados pode ser igual a zero,digite outro valor");
           else if (v1 > v2 + v3 || v2 > v1 + v3 || v3 > v1 + v2)
                Console.WriteLine("Um lado não pode ser maior do que a soma dos outros dois ");

           else  // TRIÂNGULO POSSÍVEL
            { 

                if (v1 == v2 && v2 == v3)
                    Console.WriteLine("O triângulo é Equilátero");
                else if (v1 == v2 && v3 != v2 || v3 == v1 && v3 != v2 || v3 == v2 && v3 != v1)
                    Console.WriteLine("O triângulo é Isósceles");
                else
                    Console.WriteLine("O triângulo é Escaleno");

                
            }
            var date = DateTime.UtcNow;
            Console.WriteLine(date);
        }
            
    }
}
