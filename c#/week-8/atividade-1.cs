using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Equação de 2º Grau --");
        string[] letters = { "A", "B", "C" };
        List<float> numbers = new List<float>();

        for (int i = 0; i < 3; i++)
        {
                Console.Write($"Digite o valor da variável {letters[i]}: ");
                float j = float.Parse(Console.ReadLine());
                numbers.Add(j);
        }

        try
        {
            float a = numbers[0];
            float b = numbers[1];
            float c = numbers[2];

            float delta = (b * b) - 4 * a * c;
            float sqrtDelta = (float)Math.Sqrt(delta);

            float finalAnswerA = (-b + sqrtDelta) / (2 * a);
            float finalAnswerB = (-b - sqrtDelta) / (2 * a);

            if (delta > 0)
            {
                Console.WriteLine($"As raízes da equação são {finalAnswerA} e {finalAnswerB}.");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"A única raiz da equação é {finalAnswerA}.");
            }
            else
            {
                Console.WriteLine("Não existem raízes reais para a equação.");
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Erro de divisão por zero: " + e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Erro: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
        }
    }
}
