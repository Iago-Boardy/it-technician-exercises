using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculando Fibonnaci");
        
        Console.Write("Digite um valor para calcular fibonnaci: ");
        int a = int.Parse(Console.ReadLine());
        
        int resposta = SubRotina(a);
        Console.WriteLine($"O resultado da soma fibonnaci e: {resposta}");
    }
    
    public static int SubRotina(int a) {
        if (a == 0) return 0;
        if (a == 1) return 1;
        
        int antes = 0;
        int soma = 1;
        int resposta = 0;
        
        for (int i = 2; i <= a; i++) {
            resposta = antes + soma;
            antes = soma;
            soma = resposta;
        }
        
        return resposta;
    }
}
