using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 12. Refaça o exercício anterior utilizando o switch case. */

            int codigo;
            Console.WriteLine("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo) {
                case 1:
                    Console.WriteLine("001 - Parafuso");
                    break;
                case 2:
                    Console.WriteLine("002 - Porca");
                    break;
                case 3:
                    Console.WriteLine("003 - Prego");
                    break;
                default:
                    Console.WriteLine("Não definido");
                    break;

            }

      
        }
    }
}
