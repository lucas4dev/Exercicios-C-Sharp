using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENUNCIADO
            /* 11. Utilize a estrutura SE para fazer um programa que retorne o nome de um produto a partir do 
            código do mesmo. Considere os seguintes códigos:
            a. 001 - Parafuso;
            b. 002 - Porca;
            c. 003 - Prego;
            d. Para qualquer outro código indicar "Não definido".
            */

            string codigo;
            Console.WriteLine("Digite o código do produto: ");
            codigo = Console.ReadLine();

            if (codigo == "001")
                Console.WriteLine("Você escolheu o Parafuso");
            else if (codigo == "002")
                Console.WriteLine("Você escolheu a Porca");
            else if (codigo == "003")
                Console.WriteLine("Você escolheu o Prego");
            else 
                Console.WriteLine("Código não encontrado, tente novamente.");
        }

        

    }
}
