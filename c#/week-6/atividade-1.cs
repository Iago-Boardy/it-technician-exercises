using System;
using System.Collections.Generic;

public class Semana6
{
    public static void Main(string[] args)
    {
        string[] nomes = new string[50];
        HashSet<string> conjuntoNomes = new HashSet<string>();

        for (int i = 0; i < nomes.Length; i++)
        {
            string nome;
            do
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                nome = Console.ReadLine();

                if (conjuntoNomes.Contains(nome))
                {
                    Console.WriteLine($"O nome '{nome}' já foi adicionado. Por favor, insira outro nome.");
                }
                else
                {
                    conjuntoNomes.Add(nome);
                    nomes[i] = nome;
                }
            } while (nomes[i] == null);
        }

        Array.Sort(nomes);

        Console.WriteLine();
        Console.WriteLine("Nomes ordenados:");

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($"{i + 1}- {nomes[i]}");
        }

        Console.WriteLine();
        Console.Write("Qual nome quer buscar: ");
        string busca = Console.ReadLine();
        int indice = Array.BinarySearch(nomes, busca);

        Console.WriteLine();

        if (indice >= 0)
        {
            Console.WriteLine($"Nome encontrado no índice: {indice + 1}");
            Console.WriteLine($"{nomes[indice]}");
        }
        else
        {
            Console.WriteLine("Nome não encontrado!");
        }
    }
}
