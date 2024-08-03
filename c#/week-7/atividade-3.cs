using System;
using System.Collections.Generic;
using System.Linq;

class DonaMinhoca
{
    static List<int>[] graph;
    static int[] depth;
    static bool[] visited;
    static int maxLength = 0;
    static int maxCount = 0;

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        graph = new List<int>[N + 1];
        depth = new int[N + 1];
        visited = new bool[N + 1];

        for (int i = 1; i <= N; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 0; i < N - 1; i++)
        {
            var input = Console.ReadLine().Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            graph[X].Add(Y);
            graph[Y].Add(X);
        }

        for (int i = 1; i <= N; i++)
        {
            Array.Fill(depth, -1);
            DFS(i, -1, 0);
        }

        Console.WriteLine(maxLength);
        Console.WriteLine(maxCount);
    }

    static void DFS(int node, int parent, int d)
    {
        visited[node] = true;
        depth[node] = d;

        foreach (var neighbor in graph[node])
        {
            if (neighbor == parent) continue;

            if (depth[neighbor] == -1)
            {
                DFS(neighbor, node, d + 1);
            }
            else
            {
                int cycleLength = depth[node] - depth[neighbor] + 1;
                if (cycleLength > maxLength)
                {
                    maxLength = cycleLength;
                    maxCount = 1;
                }
                else if (cycleLength == maxLength)
                {
                    maxCount++;
                }
            }
        }
    }
}
