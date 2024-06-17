using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de identificação do aluno: ");
        int numeroAluno = int.Parse(Console.ReadLine());

        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a média dos exercícios: ");
        double ME = double.Parse(Console.ReadLine());

        double MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;

        char conceito;
        if (MA >= 90)
            conceito = 'A';
        else if (MA >= 75)
            conceito = 'B';
        else if (MA >= 60)
            conceito = 'C';
        else if (MA >= 40)
            conceito = 'D';
        else
            conceito = 'E';

        string status = (conceito == 'A' || conceito == 'B' || conceito == 'C') ? "Aprovado" : "Reprovado";

        Console.WriteLine($"\nNúmero do Aluno: {numeroAluno}");
        Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
        Console.WriteLine($"Média dos Exercícios: {ME}");
        Console.WriteLine($"Média de Aproveitamento: {MA:F2}");
        Console.WriteLine($"Conceito: {conceito}");
        Console.WriteLine($"Status: {status}");
    }
}
