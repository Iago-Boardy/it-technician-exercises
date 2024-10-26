using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool keep = true;
        List<string> pilha = new List<string>();

        while (keep)
        {
            Console.WriteLine("\n--- Bem-vindo ao Sistema de Pilha ---\n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Criar pilha e seus valores");
            Console.WriteLine("2 - Consultar valores da pilha");
            Console.WriteLine("3 - Alterar valores da pilha");
            Console.WriteLine("4 - Excluir valores da pilha");

            int choose;
            if (!int.TryParse(Console.ReadLine(), out choose))
            {
                Console.WriteLine("Opção inválida! Digite um número.");
                continue;
            }

            switch (choose)
            {
                // Adicionando valores à pilha - Opção 1
                case 1:
                    Console.WriteLine("--- Adicionando na Pilha ---");
                    if (pilha.Count > 0)
                    {
                        Console.WriteLine("A pilha já foi criada! Reinicie o programa caso queira outra pilha.");
                    }
                    else
                    {
                        Console.Write("Qual o tamanho da pilha: ");
                        int length;
                        if (int.TryParse(Console.ReadLine(), out length) && length <= 50)
                        {
                            for (int i = 0; i < length; i++)
                            {
                                Console.Write($"Digite o valor da posição {i + 1}: ");
                                pilha.Add(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tamanho inválido! O máximo permitido é 50.");
                        }
                    }
                    break;

                // Consultando os valores da pilha - Opção 2
                case 2:
                    Console.WriteLine("--- Consulta da Pilha ---");
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("A pilha está vazia!");
                    }
                    else
                    {
                        for (int i = 0; i < pilha.Count; i++)
                        {
                            Console.WriteLine($"Valor {i + 1}: {pilha[i]}");
                        }
                    }
                    break;

                // Editando os valores da pilha - Opção 3
                case 3:
                    Console.WriteLine("--- Editando a Pilha ---");
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("Primeiro crie uma pilha para poder editá-la!");
                    }
                    else
                    {
                        for (int i = 0; i < pilha.Count; i++)
                        {
                            Console.WriteLine($"Valor atual na posição {i + 1}: {pilha[i]}");
                            Console.Write("Você deseja editar esse valor? (s/n): ");
                            string editChoice = Console.ReadLine().ToLower();

                            if (editChoice == "s")
                            {
                                Console.Write("Digite o novo valor: ");
                                pilha[i] = Console.ReadLine();
                                Console.WriteLine($"Valor na posição {i + 1} atualizado para: {pilha[i]}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor não alterado.");
                            }
                        }
                    }
                    break;

                // Deletando valores da pilha - Opção 4
                case 4:
                    Console.WriteLine("--- Deletando da Pilha ---");
                    if (pilha.Count == 0)
                    {
                        Console.WriteLine("A pilha está vazia! Primeiro crie uma pilha para poder excluí-la.");
                    }
                    else
                    {
                        Console.Write("Deseja apagar a pilha inteira? (s/n): ");
                        string deleteChoice = Console.ReadLine().ToLower();
                        if (deleteChoice == "s")
                        {
                            pilha.Clear();
                            Console.WriteLine("Pilha deletada com sucesso!");
                        }
                        else
                        {
                            Console.Write($"Digite a posição do valor que deseja remover (1 a {pilha.Count}): ");
                            int index;
                            if (int.TryParse(Console.ReadLine(), out index) && index > 0 && index <= pilha.Count)
                            {
                                string removido = pilha[index - 1];
                                pilha.RemoveAt(index - 1);
                                Console.WriteLine($"Valor '{removido}' removido da posição {index}.");
                            }
                            else
                            {
                                Console.WriteLine("Posição inválida!");
                            }
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            // Verificar se o usuário quer continuar no programa
            Console.Write("Terminar programa? s - sim, n - não: ");
            string end = Console.ReadLine().ToLower();
            if (end == "s")
            {
                keep = false;
            }
        }

        Console.WriteLine("\nAgradecemos o tempo em que esteve com a gente!");
    }
}
