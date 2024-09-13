using System;
using System.Collections.Generic;

class VectorOperations
{
    private static List<int> vector = new List<int>();

    static void Main()
    {
        int option;
        do
        {
            DisplayMenu();
            option = GetOption();

            switch (option)
            {
                case 1:
                    LoadVector();
                    break;
                case 2:
                    ListVector();
                    break;
                case 3:
                    ShowEvenNumbers();
                    break;
                case 4:
                    ShowOddNumbers();
                    break;
                case 5:
                    CountEvenNumbersInOddPositions();
                    break;
                case 6:
                    CountOddNumbersInEvenPositions();
                    break;
                case 7:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        } while (option != 7);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1 - Carregar Vetor");
        Console.WriteLine("2 - Listar Vetor");
        Console.WriteLine("3 - Exibir apenas os números pares do vetor");
        Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
        Console.WriteLine("5 - Exibir a quantidade de números pares que existem nas posições ímpares do vetor");
        Console.WriteLine("6 - Exibir a quantidade de números ímpares que existem nas posições pares do vetor");
        Console.WriteLine("7 - Sair");
    }

    static int GetOption()
    {
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void LoadVector()
    {
        vector.Clear();
        Console.Write("Quantos números deseja inserir? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vector.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Vetor carregado com sucesso!");
    }

    static void ListVector()
    {
        if (vector.Count == 0)
        {
            Console.WriteLine("O vetor está vazio.");
            return;
        }

        Console.WriteLine("Elementos do vetor:");
        for (int i = 0; i < vector.Count; i++)
        {
            Console.WriteLine($"Posição {i}: {vector[i]}");
        }
    }

    static void ShowEvenNumbers()
    {
        Console.WriteLine("Números pares do vetor:");
        foreach (int num in vector)
        {
            if (num % 2 == 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }

    static void ShowOddNumbers()
    {
        Console.WriteLine("Números ímpares do vetor:");
        foreach (int num in vector)
        {
            if (num % 2 != 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }

    static void CountEvenNumbersInOddPositions()
    {
        int count = 0;
        for (int i = 1; i < vector.Count; i += 2)
        {
            if (vector[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Quantidade de números pares em posições ímpares: {count}");
    }

    static void CountOddNumbersInEvenPositions()
    {
        int count = 0;
        for (int i = 0; i < vector.Count; i += 2)
        {
            if (vector[i] % 2 != 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Quantidade de números ímpares em posições pares: {count}");
    }
}
