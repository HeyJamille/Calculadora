using System;

namespace Calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    // Método Menu
    static void Menu()
    {
      Console.Clear(); // Limpa a tela

      Console.WriteLine("Escolha o tipo de calculadora que gostaria de:");
      Console.WriteLine("1 - Soma \n" +
                        "2 - Subtração \n" +
                        "3 - Multiplicação \n" +
                        "4 - Divisão \n" +
                        "5 - Sair \n");

      Console.Write("Opção: ");
      int opcao = int.Parse(Console.ReadLine());

      Console.WriteLine("\n------------------------------------------------");

      switch (opcao)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Multiplicacao();
          break;
        case 4:
          Divisao();
          break;
        case 5:
          Sair();
          break;
      }
    }

    // Método Soma
    static void Soma()
    {
      float num_1, num_2;

      Console.Write("1º número: ");
      num_1 = float.Parse(Console.ReadLine());

      Console.Write("2º número: ");
      num_2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float soma = (num_1 + num_2);
      Console.WriteLine($"Resultado: {soma}");
    }

    // Método Subtracao
    static void Subtracao()
    {
      float num_1, num_2;

      Console.Write("1º número: ");
      num_1 = float.Parse(Console.ReadLine());

      Console.Write("2º número: ");
      num_2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float subtracao = (num_1 - num_2);
      Console.WriteLine($"Resultado: {subtracao}");
    }

    // Método Multiplicacao
    static void Multiplicacao()
    {
      float num_1, num_2;

      Console.Write("1º número: ");
      num_1 = float.Parse(Console.ReadLine());

      Console.Write("2º número: ");
      num_2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float multiplicacao = (num_1 * num_2);
      Console.WriteLine($"Resultado: {multiplicacao}");
    }

    // Método Divisao
    static void Divisao()
    {
      float num_1, num_2;

      Console.Write("1º número: ");
      num_1 = float.Parse(Console.ReadLine());

      Console.Write("2º número: ");
      num_2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float divisao = (num_1 / num_2);
      Console.WriteLine($"Resultado: {divisao}");
    }

    // Método Sair
    static void Sair()
    {
      Console.WriteLine("Obrigado por utilizar o nosso sistema. Até mais! :)");
      System.Environment.Exit(0); // Sai do sistema
    }
  }
}








