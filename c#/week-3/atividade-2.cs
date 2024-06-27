using System;

public class Atividade2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vamos calcular o seu IMC");
        Console.Write("Digite o seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        
        Console.Write("Digite a sua altura: ");
        double altura = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é {imc}");
        
        if (imc < 18.5) {
            Console.WriteLine("Abaixo do Peso");
        } else if (imc >= 18.5 && imc < 25) {
            Console.WriteLine("Peso normal");
        } else if (imc >= 25 && imc < 30) {
            Console.WriteLine("Acima do peso");
        } else if (imc >= 30) {
            Console.WriteLine("Obeso");
        }
    }
}
