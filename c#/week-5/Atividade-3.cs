using System;
using System.Collections.Generic;

public struct Aluno
{
    public int Cartao;
    public int Idade;
    public string[] Respostas;

    public Aluno(int cartao, int idade, string[] respostas)
    {
        Cartao = cartao;
        Idade = idade;
        Respostas = respostas;
    }
}

class Program
{
    static void Main()
    {
        string[] gabarito = {"E", "A", "C", "C", "A", "B", "E", "D", "D", "D",
                             "A", "C", "A", "E", "E", "E", "A", "C", "C", "A",
                             "B", "E", "D", "D", "D", "A", "C", "A", "E", "E"};

        List<Aluno> alunos = new List<Aluno>();

        Console.Write("Digite quantos alunos fizeram a prova: ");
        int n_alunos = int.Parse(Console.ReadLine());

        for (int i = 0; i < n_alunos; i++)
        {
            Console.WriteLine($"\nDigite os dados do aluno {i + 1}:");
            
            Console.Write("Número do Cartão: ");
            int cartao = int.Parse(Console.ReadLine());

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            
            string[] respostasAluno = new string[gabarito.Length];
            for (int j = 0; j < gabarito.Length; j++)
            {
                Console.Write($"Digite a resposta para a questão {j + 1} (A, B, C, D ou E): ");
                respostasAluno[j] = Console.ReadLine().ToUpper();
            }

           
            Aluno novoAluno = new Aluno(cartao, idade, respostasAluno);
            alunos.Add(novoAluno);
        }

        for (int i = 0; i < alunos.Count; i++)
        {
            int acertos = 0;

            for (int j = 0; j < gabarito.Length; j++)
            {
                if (alunos[i].Respostas[j] == gabarito[j])
                {
                    acertos++;
                }
            }

            Console.WriteLine($"\nAluno Cartão {alunos[i].Cartao}: Acertos = {acertos}");
        }
    }
}
