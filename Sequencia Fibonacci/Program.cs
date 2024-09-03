using System.Collections.Generic;
namespace Sequencia_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

            Console.WriteLine("Insira uma quantidade de números: ");
            List<int> list = new List<int>();
            int quantidade = int.Parse(Console.ReadLine());
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            Console.WriteLine("Insira um valor para verificar se ele está na sequência");
            int valor = int.Parse(Console.ReadLine());
            Console.Write("{");
            for (int i = 0; i < quantidade; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                if (i == 0)
                {
                    Console.Write(numeroAnterior + ",");
                    list.Add(numeroAnterior);
                    Console.Write(numeroAtual + ",");
                    list.Add(numeroAtual);
                }
                else
                {
                    Console.Write(fibonacci + ",");
                    list.Add(fibonacci);
                    numeroAnterior = numeroAtual;
                    numeroAtual = fibonacci;
                }
            }
            Console.Write("}");
            Console.WriteLine();
            if (list.Contains(valor))
            {
                Console.WriteLine("Ele está integrado dentro da sequência");
            }
            else
            {
                Console.WriteLine("O valor inserido, não está na sequência de fibonacci");
            }
        }
    }
}