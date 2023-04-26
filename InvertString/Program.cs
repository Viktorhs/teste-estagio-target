using System;

namespace InvertString
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite uma palavra: ");
      string palavra = Console.ReadLine();
      int tamanho = palavra.Length;

      char[] arrayCaracteres = new char[tamanho];

      for (int i = 0; i < tamanho; i++)
      {
        arrayCaracteres[i] = palavra[i];
      }

      for (int i = 0; i < tamanho / 2; i++)
      {
        char temp = arrayCaracteres[i];
        arrayCaracteres[i] = arrayCaracteres[tamanho - i - 1];
        arrayCaracteres[tamanho - i - 1] = temp;
      }

      string palavraInvertida = new string(arrayCaracteres);
      Console.WriteLine($"A palavra invertida é: {palavraInvertida}");
    }
  }
}