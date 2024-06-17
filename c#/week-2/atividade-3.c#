using System;

public class Atividade3
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"Média inicial: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Digite a nota da recuperação:");
                double notaRecuperacao = double.Parse(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;
                Console.WriteLine($"Nova média: {novaMedia}");

                if (novaMedia >= 7)
                {
                    Console.WriteLine("Aluno aprovado na recuperação!");
                }
                else
                {
                    Console.WriteLine("Aluno não aprovado.");
                }
            }
        }
        
}
