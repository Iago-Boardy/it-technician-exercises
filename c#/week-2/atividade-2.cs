using System;

public class Atividade2
{
    public static void Main(string[] args)
    {
       
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            num3 = int.Parse(Console.ReadLine());

            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("Números em ordem decrescente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        
    }
}
