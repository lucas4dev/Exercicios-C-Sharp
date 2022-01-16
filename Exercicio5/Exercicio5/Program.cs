using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco_produto, valor_recebido, troco;
            //ENUNCIADO
            /* 5. Faça um programa que receba um valor que é o valor pago, um segundo valor que é o preço
             do produto e retorne o troco a ser dado. */

            Console.WriteLine("Digite o preço do produto: ");
            preco_produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido: ");
            valor_recebido = double.Parse(Console.ReadLine());

            troco = valor_recebido - preco_produto;

            if(troco > 0)
            {
                Console.WriteLine("O troco é: " +troco);
            }
            else if (troco < 0)
            {
                Console.WriteLine("O cliente saiu devendo um valor de: " + Math.Abs(troco)); // Math.abs para pegar o valor absoluto, ou seja, o negativo fica positivo.
            }
            else // troco == 0
            {
                Console.WriteLine("Não há troco");
            }
            
        }
    }
}
