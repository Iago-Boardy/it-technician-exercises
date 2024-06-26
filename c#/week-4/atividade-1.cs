using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int carteira, nm, vl, sair = 0;
        int[] total = new int[300];
        int[] multas = new int[300];
        int j = 0;
        int totalArrecadado = 0;
        int maiorNumeroMultas = 0;
        int carteiraMaiorNumeroMultas = 0;

        while (sair == 0) {
            Console.WriteLine("Qual o número da carteira?");
            carteira = int.Parse(Console.ReadLine());
            
            if (carteira > 4327 || carteira < 1) {
                Console.WriteLine("Número inválido");
                return;
            }
            
            Console.WriteLine("Qual a quantidade de multas?");
            nm = int.Parse(Console.ReadLine());
            
            multas[j] = nm;

            for (int i = 1; i <= nm; i++) {
                Console.WriteLine($"Qual o valor da multa número {i}?");
                vl = int.Parse(Console.ReadLine());
                
                total[j] += vl;
            }
            
            totalArrecadado += total[j];
            
            Console.WriteLine($"Valor total das multas: {total[j]}");
            
            if (nm > maiorNumeroMultas) {
                maiorNumeroMultas = nm;
                carteiraMaiorNumeroMultas = carteira;
            }
            
            j++;
            vl = 0;
            
            Console.WriteLine("\nVer o valor total de multas de outra pessoa: Digite 0.\nSair: Digite qualquer outra tecla.");
            sair = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"O total de recursos arrecadados é: {totalArrecadado}\nA carteira com o maior número de multas é: {carteiraMaiorNumeroMultas}");
    }
}
