using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o número de linhas da matriz A: ");
        int N1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas da matriz A: ");
        int M1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de linhas da matriz B: ");
        int N2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas da matriz B: ");
        int M2 = int.Parse(Console.ReadLine());

        if (M1 != N2)
        {
            Console.WriteLine("Erro: Não é possível multiplicar as matrizes devido às dimensões.");
            return;
        }

        double[,] A = new double[N1, M1];
        double[,] B = new double[N2, M2];

        Console.WriteLine("Digite os elementos da matriz A:");
        for (int i = 0; i < N1; i++)
        {
            for (int j = 0; j < M1; j++)
            {
                Console.Write($"Digite o elemento A[{i},{j}]: ");
                A[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os elementos da matriz B:");
        for (int i = 0; i < N2; i++)
        {
            for (int j = 0; j < M2; j++)
            {
                Console.Write($"Digite o elemento B[{i},{j}]: ");
                B[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double[,] C = new double[N1, M2];

        for (int i = 0; i < N1; i++)
        {
            for (int j = 0; j < M2; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < M1; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nMatriz Resultante C (Produto das Matrizes A e B):");
        for (int i = 0; i < N1; i++)
        {
            for (int j = 0; j < M2; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
