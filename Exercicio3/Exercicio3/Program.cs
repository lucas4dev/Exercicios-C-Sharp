using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 3. Crie um algoritmo que leia 2 números e mostre a sua diferença */

            Console.WriteLine("Insira 2 numeros para realizar a subtração:");
            int numero1, numero2;
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A diferença entre " + numero1 + " e " + numero2 + " é " + (numero1 - numero2));
        }
    }
}
