using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO 
            /* 4. Pretende-se lendo a base e altura de um triângulo calcular a sua área */
            //nao coloquei "base", pois é uma palavra reservada do C#, então coloquei como b

            double b, altura, area;

            Console.WriteLine("Insira o valor da base do triangulo: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da altura do triangulo: ");
            altura = double.Parse(Console.ReadLine());

            area = (b * altura) / 2;
            Console.WriteLine("O valor da area do triângulo de base " + b + " e altura " + altura + " é: " + area);
            
        }
    }
}
