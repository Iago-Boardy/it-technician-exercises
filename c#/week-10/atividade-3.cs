using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculando Potências");
        
        Console.Write("Digite o expoente (a): ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Digite a base (b): ");
        int b = int.Parse(Console.ReadLine());
        
        int resposta = SubRotina(a, b);
        Console.WriteLine($"O resultado de {b} elevado a {a} é: {resposta}");
    }
    
    public static int SubRotina(int a, int b) {
        if (a == 0) return 1; 
        if (a == 1) return b; 
        
        int resultado = 1;
        
        for (int i = 0; i < a; i++) {
            resultado *= b; 
        }
        
        return resultado;
    }
}
