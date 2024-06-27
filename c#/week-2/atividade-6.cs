using System;

public class Atividade6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do lado A:");
        double ladoA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado B:");
        double ladoB = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do lado C:");
        double ladoC = double.Parse(Console.ReadLine());

        if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("O triângulo e isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo e escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores fornecidos não caracterizam um triângulo.");
        }
    }
}
