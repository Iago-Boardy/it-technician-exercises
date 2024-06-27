using System;

public class Atividade1
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number < 0) {
            number = number * (-1);
            Console.WriteLine($"O numero negativo foi transformado para {number}");
        } else {
            Console.WriteLine($"O numero ja e positivo!");
            Console.WriteLine(number); 
        }
    }
}
