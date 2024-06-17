#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct User
{
    int idChar;
    char nome[50];
    char email[50];
    char telefone[14];
    char status;
} User;

User GetUser() //Pega as informações de cadastro de registro que o usuário quer
{
    User user;
    static int lastIdChar = 0;
    user.idChar = ++lastIdChar;
    printf("\tDigite o nome do usuário: ");
    fgets(user.nome, 50, stdin);
    printf("\tDigite o email do usuário: ");
    fgets(user.email, 50, stdin);
    printf("\tDigite o telefone do usuário: ");
    fgets(user.telefone, 14, stdin);
    user.status = '1';
    return user;
}

void PrintUser(User user, FILE *fptr) //printa as informações dentro do arquivo .txt
{
        fprintf(fptr, "\nId: %d\n", user.idChar);
        fprintf(fptr, "Nome: %s", user.nome);
        fprintf(fptr, "Email: %s", user.email);
        fprintf(fptr, "Telefone: %s", user.telefone);
        fprintf(fptr, "Status: %c\n", user.status);
}

int main()
{
    char resp;
    int opcao;
    User user;
    FILE *fptr;
    char fileName[100];
    char line[1000];

    printf("Sistema de registro de usuários:\n");

    printf("Digite o nome do arquivo que quer usar: ");
    fgets(fileName, sizeof(fileName), stdin);

    do
    {
        printf("\n1. Inserir registro\n");
        printf("2. Consultar registros\n");
        printf("3. Excluir um registro\n");
        printf("4. Fim\n\n");
        printf("O que deseja fazer? ");
        scanf("%d", &opcao);
        getchar(); 

        switch (opcao)
        {
        case 1:
            if ((fptr = fopen(fileName, "a+")) == NULL)
            {
                printf("Erro ao abrir o arquivo.\n");
                exit(1);
            }

            do
            {
                user = GetUser();
                PrintUser(user, fptr);
                printf("Mais um registro (s/n)? ");
                resp = getchar();
                getchar(); 
            } while (resp == 's' || resp == 'S');

            fclose(fptr);
            break;

        case 2:
            if ((fptr = fopen(fileName, "r")) == NULL)
            {
                printf("Erro ao abrir o arquivo.\n");
                exit(1);
            }

            printf("\nTodos os registros:\n");
            printf("====================\n");
            while (fgets(line, sizeof(line), fptr) != NULL) { //Realiza a consulta de registros por linha
                printf("%s", line);
            }
            printf("====================\n");
            fclose(fptr);
            break;

        case 3: 
            if ((fptr = fopen(fileName, "r+")) == NULL)
            {
                printf("Erro ao abrir o arquivo.\n");
                exit(1);
            }

            int deleteId;
            printf("Digite o número do ID que deseja excluir: ");
            scanf("%d", &deleteId);
            getchar(); 

            if (deleteId == user.idChar) {
                //escrever o necessário para exclusao
            }

            int found = 0;
            FILE *tempFile = fopen("temp.txt", "w");
            if (tempFile == NULL)
            {
                printf("Erro ao criar arquivo temporário.\n");
                fclose(fptr);
                exit(1);
            }

            while (fscanf(fptr, "Id: %d\n", &user.idChar) == 1)
            {
                fgets(user.nome, sizeof(user.nome), fptr);
                fgets(user.email, sizeof(user.email), fptr);
                fgets(user.telefone, sizeof(user.telefone), fptr);
                fscanf(fptr, "Status: %c\n", &user.status);

                if (user.idChar == deleteId)
                {
                    found = 1;
                    printf("\nUsuário excluído!\n");
                }
                else
                {
                    PrintUser(user, tempFile);
                }
            }

            fclose(fptr);
            fclose(tempFile);

            remove(fileName);
            rename("temp.txt", fileName);

            if (!found)
            {
                printf("Usuário com o ID especificado não encontrado.\n");
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
