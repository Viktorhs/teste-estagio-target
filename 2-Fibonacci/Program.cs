using System;

namespace Fibonacci
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite um número inteiro: ");
      int num = int.Parse(Console.ReadLine()); // informar o numero pelo console.
      // int num = 0; //se preferir tire o comentario da linha e comente a anterior e insira o valor desejado na variavel.

      int fib1 = 0;
      int fib2 = 1;

      while (fib2 < num)
      {
        int temp = fib2;
        fib2 = fib1 + fib2;
        fib1 = temp;
      }

      if (fib2 == num)
      {
        Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
      }
      else
      {
        Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
      }
    }
  }
}