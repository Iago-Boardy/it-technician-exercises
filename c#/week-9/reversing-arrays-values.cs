using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Bem vindo ao inversor de vetores: ");
        Console.WriteLine("Qual será o tamanho da sua lista: ");
        int lista = int.Parse(Console.ReadLine());
        List<int> numerosA = new List<int>();
        List<int> numerosB = new List<int>();
        
        Console.WriteLine();
        
        for (int i = 0; i < lista; i++) {
            Console.WriteLine($"Qual é o {i+1} valor: ");
            int value = int.Parse(Console.ReadLine());
            numerosA.Add(value);
        }
        
        Console.WriteLine();
        
        
        for (int i = 0; i < lista; i++) {
            numerosB.Add(numerosA[i]);
        }
        
        numerosB.Reverse();
        
        
        Console.WriteLine("Lista A em ordem crescente: ");
        for (int i = 0; i < lista; i++) {
            Console.WriteLine($"{numerosA[i]}");
        }
        
        Console.WriteLine();
        
        Console.WriteLine("Lista B em ordem invertida a lista A: ");
        for (int i = 0; i < lista; i++) {
            Console.WriteLine($"{numerosB[i]}");
        }
        
        
        
    }
}

