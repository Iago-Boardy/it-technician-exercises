using System;
using System.Collections.Generic;

public class Atividade1
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a quantia de elementos do primeiro vetor: ");
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];

        Console.Write("Digite a quantia de elementos do segundo vetor: ");
        int M = int.Parse(Console.ReadLine());
        int[] B = new int[M];

        for (int i = 0; i < A.Length; i++) 
        {
            Console.Write($"Digite o elemento {i+1} do vetor A: ");
            A[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\n");

        for (int i = 0; i < B.Length; i++) 
        {
            Console.Write($"Digite o elemento {i+1} do vetor B: ");
            B[i] = int.Parse(Console.ReadLine());
        }

        List<int> C = new List<int>();
        
        foreach (int valorA in A)
        {
            if (Array.Exists(B, element => element == valorA))
            {
                C.Add(valorA);
            }
        }

        int[] intersecao = C.ToArray();

        // HashSet Cria uma lista que impede que valores se repitam
        HashSet<int> D = new HashSet<int>();
        
        // Adiciona os valores dentro do HashSet
        foreach (int valorA in A)
        {
            D.Add(valorA);
        }

        foreach (int valorB in B)
        {
            D.Add(valorB);
        }

        int[] uniao = new int[D.Count];
        D.CopyTo(uniao);

        Console.Write("\n");
        Console.WriteLine("Vetor A: " + string.Join(", ", A));
        Console.WriteLine("Vetor B: " + string.Join(", ", B));
        Console.WriteLine("Vetor C (Intersecao): " + string.Join(", ", intersecao));
        Console.WriteLine("Vetor D (Uniao): " + string.Join(", ", uniao));
    }
}
