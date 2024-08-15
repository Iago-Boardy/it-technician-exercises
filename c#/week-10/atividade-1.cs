using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Subrotina de soma");
        
        Console.Write("Digite um valor para somar com seus anteriores: ");
        int a = int.Parse(Console.ReadLine());
        
        int soma = SubRotina(a);
        Console.WriteLine($"O resultado da soma e: {soma}");
    }
    
    public static int SubRotina(int a) {
        int resposta = 0;
        for (int i = 0; i <= a; i++) {
            resposta += i;
        }
        
        return resposta;
    }
}
