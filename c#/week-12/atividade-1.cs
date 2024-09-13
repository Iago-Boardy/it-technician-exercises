using System;

class CharacterCounter
{
    static void Main()
    {
        Console.WriteLine("Digite 2 caracteres:");
        string input = Console.ReadLine();

        if (input.Length != 3 || !char.IsLetter(input[0]) || !char.IsLetter(input[2]) || input[1] != ' ')
        {
            Console.WriteLine("Erro: Por favor, digite dois caracteres separados por espaço.");
            return;
        }

        char first = char.ToUpper(input[0]);
        char second = char.ToUpper(input[2]);

        if (first > second)
        {
            Console.WriteLine("Erro: Os caracteres não estão em ordem alfabética.");
            return;
        }

        int distance = second - first - 1;
        Console.WriteLine($"O número de caracteres entre eles é: {distance}");
    }
}
