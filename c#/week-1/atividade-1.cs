using System;

public class Atividade1
{
    public static void Main(string[] args)
    {
        //Começamos pedindo qual conversão ele quer que aconteça
        Console.WriteLine ("Bem vindo ao conversor de temperatura!\n");
        Console.WriteLine("\tO que deseja fazer?");
        Console.WriteLine("\tConverter Graus Celcius em Fahrenheit (digite 1)");
        Console.WriteLine("\tConverter Fahrenheit em Graus Celcius (digite 2)");
        
        string input = Console.ReadLine();
        int choose;
        
        if (!int.TryParse(input, out choose))
        {
            Console.WriteLine("Digite um valor valido!");
        }
        else if (choose < 1 || choose > 2)
        {
            Console.WriteLine("Digite um valor valido!");
        }
        
        //Agora a conversão de Celcius para Fahrenheit
        if (choose == 1) {
            double celcius;
            
            Console.WriteLine("\tDigite os graus Celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());
            
            celcius = (celcius*1.8) + 32;
            
            Console.WriteLine($"\tSao {celcius} fahrenheit");
        }
        
        //Agora a conversão de Fahrenheit para Celcius
        if (choose == 2) {
            double fahrenheit;
            
            Console.WriteLine("\tDigite os Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            fahrenheit = (fahrenheit - 32) / 1.8;
            
            Console.WriteLine($"\tSao {fahrenheit} graus celcius");
        }
    }
}

