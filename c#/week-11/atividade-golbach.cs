
using System;
using System.Collections.Generic;

public class AtividadeGolbach
{
    public static bool tryPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;
        
        for (int i = 3; i * i <= numero; i += 2)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine("-Conjetura de Goldbach-");
        Console.WriteLine();
        Console.WriteLine("Digite um número PAR entre 700 e 1100 para comprovar a conjectura de Goldbach.");
        Console.WriteLine();

        int par = 0;

        Console.Write("Digite o número: ");
        par = int.Parse(Console.ReadLine());

        if (par < 700 || par > 1100) 
        {
            Console.WriteLine("Digite um número par entre 700 e 1100!");
        } 
        else if (par % 2 != 0) 
        {
            Console.WriteLine("Digite um número par!");
        } 
        else 
        {
            List<int> primos = new List<int>();

            for (int i = 2; i <= par; i++)
            {
                if (tryPrimo(i))
                {
                    primos.Add(i);
                }
            }

            bool encontrouPar = false;

            
            foreach (int p1 in primos)
            {
                int p2 = par - p1;
                if (primos.Contains(p2))
                {
                    Console.WriteLine($"{par} = {p1} + {p2}");
                    encontrouPar = true;
                    break;
                }
            }

          
        }
    }
}


