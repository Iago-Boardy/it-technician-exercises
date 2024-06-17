using System;

public class Atividade3
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o preço do produto: ");
        double value = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\nSistema de desconto de produtos\n");
        Console.Write("A vista no dinheiro ou cheque (1) \n");
        Console.Write("A vista no cartão de crédito (2) \n");
        Console.Write("Em duas vezes (3) \n");
        Console.Write("Em mais de duas vezes (4)\n");
        Console.Write("Como será o pagamento: ");
        int choose = int.Parse(Console.ReadLine());
        
        switch (choose)
        {
            case 1:
                value = value - (value * 0.10); 
                break;
            case 2:
                value = value - (value * 0.15); 
                break;
            case 3:
                break;
            case 4:
                value = value + (value * 0.15); 
                break;
            default:
                Console.WriteLine("Número inválido, favor digitar um número válido!!");
                return; 
        }
        
        Console.WriteLine($"O preço final do produto após a escolha do método de pagamento é {value}");
    }
}
