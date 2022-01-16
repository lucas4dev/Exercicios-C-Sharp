using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enunciado
            /* 1. Crie um algoritmo que lê o nome de uma pessoa e escreve 
             "Olá" seguido do nome da pessoa. */

            Console.WriteLine("Digite seu nome, por favor: ");
            string nome = string.Format(Console.ReadLine());
            Console.WriteLine("Olá, " + nome);
        }
    }
}
