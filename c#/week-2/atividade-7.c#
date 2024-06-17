using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numero1, numero2;
        
        Console.WriteLine("Digite o primeiro numero inteiro:");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero inteiro:");
        numero2 = int.Parse(Console.ReadLine());

        int opcao;
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Verificar se um numero é multiplo do outro");
            Console.WriteLine("2 - Verificar se os dois numeros sao pares");
            Console.WriteLine("3 - Verificar se a média dos numeros e maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                    }
                    break;
                case 2:
                    if (numero1 % 2 == 0 && numero2 % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Os números não são ambos pares.");
                    }
                    break;
                case 3:
                    double media = (numero1 + numero2) / 2.0;
                    if (media >= 7)
                    {
                        Console.WriteLine("A média dos números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos números é menor que 7.");
                    }
                    break;
                case 4:
                    sair = true;
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}


