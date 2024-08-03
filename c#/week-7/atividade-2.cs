using System;
using System.Collections.Generic;

public class Atividade2
{
    public static void Main(string[] args)
    {
        Console.Write("How many ingredients we're having today: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1 || N > 20)
        {
            throw new ArgumentException("Write only integers higher than 0 and less than 21!");
        }

        Console.Write("Which are the number of combinations (pairs) that shouldn't happen: ");
        int M = int.Parse(Console.ReadLine());
        
      

        List<Tuple<int, int>> prohibitedPairs = new List<Tuple<int, int>>();

        for (int i = 0; i < M; i++)
        {
            Console.WriteLine("Enter the pair of ingredients that shouldn't be combined (e.g., 1 2):");
            string[] pair = Console.ReadLine().Split();
            int X = int.Parse(pair[0]);
            int Y = int.Parse(pair[1]);
            prohibitedPairs.Add(Tuple.Create(X, Y));
        }

        int totalSandwiches = MaxSandwiches(N, prohibitedPairs);
        Console.WriteLine($"The maximum number of different sandwiches is: {totalSandwiches}");
    }


    //Here is one function
    static int MaxSandwiches(int N, List<Tuple<int, int>> prohibitedPairs)
    {
        List<List<int>> allCombinations = new List<List<int>>(); //Lists for all the combinations
        
        for (int i = 1; i <= N; i++)
        {
            GenerateCombinations(new List<int>(), 1, i, N, allCombinations);
        }

        int validCount = 0;
        foreach (var combo in allCombinations)
        {
            bool isValid = true;
            foreach (var pair in prohibitedPairs)
            {
                if (combo.Contains(pair.Item1) && combo.Contains(pair.Item2))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                validCount++;
            }
        }

        return validCount;
    }


    //Here is one function
    static void GenerateCombinations(List<int> current, int start, int depth, int N, List<List<int>> allCombinations)
    {
        if (depth == 0)
        {
            allCombinations.Add(new List<int>(current));
            return;
        }

        for (int i = start; i <= N; i++)
        {
            current.Add(i);
            GenerateCombinations(current, i + 1, depth - 1, N, allCombinations);
            current.RemoveAt(current.Count - 1);
        }
    }
}
