 using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int sair01 = 1;
        double total = 0, totalf = 0, media = 0, maior = 0, cem = 0;
        List<double> salarios = new List<double>();
        List<int> filhos = new List<int>();
        
        while (sair01 > 0) {
           int j = salarios.Count;
           
           Console.WriteLine($"Qual o salario da familia numero {j + 1}?");
           salarios.Add(double.Parse(Console.ReadLine()));
           
           if (salarios[j] <= 100) {
               cem++;
           }
           
           Console.WriteLine("Qual a quantidade de filhos dessa familia?");
           filhos.Add(int.Parse(Console.ReadLine()));
           
           Console.WriteLine("Quer cadastrar outra familia?\nSim: Digite um numero positivo.\nNao: Digite um numero negativo");
           sair01 = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < salarios.Count; i++)
        {
            total += salarios[i];
            totalf += filhos[i];
        }

        // Encontrar o maior salário
        maior = salarios[0];
        for (int c = 1; c < salarios.Count; c++) {
            if (salarios[c] > maior) {
                maior = salarios[c];
            }
        }

        cem = (cem / salarios.Count) * 100;

        Console.WriteLine($"Média salarial: {total / salarios.Count:F2}\nMédia de filhos: {totalf / filhos.Count:F2}\nMaior salário: {maior}\nPorcentagem de pessoas com salário até 100: {cem:F2}");
    }
}
