#include <stdio.h>
#include <stdlib.h>
#include <string.h> // Para usar a função strstr()

typedef struct Livro
{
    char Titulo[50];
    char Autor[50];
    short NumReg;
    double Preco;
} Livro;

Livro GetLivro()
{
    Livro livro;
    printf("\n\tDigite o titulo: ");
    getchar();
    fgets(livro.Titulo, 50, stdin);
    printf("\tDigite o nome do autor: ");
    fgets(livro.Autor, 50, stdin);
    printf("\tDigite o número do registro: ");
    scanf("%hd", &livro.NumReg);
    printf("\tDigite o preço: ");
    scanf("%lf", &livro.Preco);
    getchar();
    return livro;
}

void PrintLivro(Livro livro)
{
    printf("\n\tTitulo: %s", livro.Titulo);
    printf("\tAutor: %s", livro.Autor);
    printf("\tNr.Registro: %hd\n", livro.NumReg);
    printf("\tPreço: %.2lf\n", livro.Preco);
}

void ConsultarPorTitulo(FILE *fptr, char *titulo)
{
    Livro livro;

    printf("\n\nRESULTADOS DA CONSULTA POR TÍTULO: %s\n", titulo);
    printf("==========================================\n");

    while (fread(&livro, sizeof(Livro), 1, fptr) == 1)
    {
        if (strstr(livro.Titulo, titulo) != NULL)
        {
            PrintLivro(livro);
        }
    }
}

void ConsultarPorAutor(FILE *fptr, char *autor)
{
    Livro livro;

    printf("\n\nRESULTADOS DA CONSULTA POR AUTOR: %s\n", autor);
    printf("==========================================\n");

    while (fread(&livro, sizeof(Livro), 1, fptr) == 1)
    {
        if (strstr(livro.Autor, autor) != NULL)
        {
            PrintLivro(livro);
        }
    }
}

void ConsultarPorNumeroRegistro(FILE *fptr, short numReg)
{
    Livro livro;

    printf("\n\nRESULTADOS DA CONSULTA POR NÚMERO DE REGISTRO: %hd\n", numReg);
    printf("==========================================\n");

    while (fread(&livro, sizeof(Livro), 1, fptr) == 1)
    {
        if (livro.NumReg == numReg)
        {
            PrintLivro(livro);
        }
    }
}

int main()
{
    char resp;
    int opcao;
    Livro livro;
    FILE *fptr;

    printf("Sistema de registro de livros:\n");

    do
    {
        system("cls"); //limpa a tela
        printf("\n1. Inserir registro\n");
        printf("2. Consultar registros\n");
        printf("3. Excluir todos os registros\n");
        printf("4. Fim\n\n");
        printf("O que deseja fazer? ");
        scanf("%d", &opcao);

        switch (opcao)
        {
         case 1:
            if ((fptr = fopen("Livros.txt", "a+")) == NULL)
            {
               printf("Erro ao abrir o arquivo.\n");
               exit(1);
            }

            do
            {
               livro = GetLivro();
               fwrite(&livro, sizeof(Livro), 1, fptr);
               printf("Mais um livro (s/n)? ");
               opcao = getchar();
            } while (opcao == 's' || opcao == 'S');

            fclose(fptr);
            break;

        case 2:
            if ((fptr = fopen("Livros.txt", "rb")) == NULL)
            {
                printf("Erro ao abrir o arquivo.\n");
                exit(1);
            }

            fseek(fptr, 0, SEEK_END);
            if (ftell(fptr) == 0)
            {
                printf("Não há informações disponíveis.\n");
                fclose(fptr);
                break;
            }
            rewind(fptr);

            int consultaOpcao;
            printf("\nEscolha a opção de consulta:\n");
            printf("1. Por título\n");
            printf("2. Por autor\n");
            printf("3. Por número de registro\n");
            printf("Opção: ");
            scanf("%d", &consultaOpcao);

            switch (consultaOpcao)
            {
            case 1:
                printf("Digite o título a ser consultado: ");
                getchar();
                fgets(livro.Titulo, 50, stdin);
                ConsultarPorTitulo(fptr, livro.Titulo);
                break;
            case 2:
                printf("Digite o autor a ser consultado: ");
                getchar();
                fgets(livro.Autor, 50, stdin);
                ConsultarPorAutor(fptr, livro.Autor);
                break;
            case 3:
                printf("Digite o número de registro a ser consultado: ");
                scanf("%hd", &livro.NumReg);
                ConsultarPorNumeroRegistro(fptr, livro.NumReg);
                break;
            default:
                printf("Opção de consulta inválida.\n");
                break;
            }

            fclose(fptr);
            break;

           case 3:
            printf("\nDeseja mesmo excluir todos os registros (s/n)? ");
            getchar();
            resp = getchar();
            if (resp == 's' || resp == 'S') {
                if (remove("Livros.txt") == 0) {
                    printf("Todos os registros foram excluídos com sucesso.\n");
                } else {
                    printf("Erro ao excluir os registros.\n");
                }
            } else {
                printf("Exclusão cancelada.\n");
            }
            break;

        case 4:
            printf("Saindo...\n");
            break;

        default:
            printf("Opção inválida.\n");
        }
    } while (opcao != 4);

    return 0;
}
