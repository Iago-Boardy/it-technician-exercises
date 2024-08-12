#include <stdio.h>
#include <string.h>

int main() {
    printf("Bem vindo ao Worldle!\nVocê tem 6 tentativas para adivinhar qual a palavra (apenas letras minúsculas):\n\nLetra na posição correta(*).\nLetra correta, mas na posição errada:(+).\nLetra não faz parte da palavra(-).\n\n"); //Introduzindo o jogo

    char answer[6] = "ivoti"; // Resposta do jogo, que pode ser alterável.
    char try[6]; //String da tentativa do jogador.
    char help[6]; //String de ajuda para o jogador.

    for (int i = 0; i < 6; i++) { 
        printf("Tentativa número %d:\n", i + 1);
        gets(try); //Pega a resposta do jogador.

        if (strlen(try) >= 6) {
            printf("Número inválido! Digite 5 letras");
            return 0; //Caso a palavra não tenha exatamente 5 letras
        }
        
        if (strlen(try) <= 4) {
            printf("Número inválido! Digite 5 letras");
            return 0; //Caso a palavra não tenha exatamente 5 letras
        }

        // Faz com que todas as letras da string help tenham o valor '-'.
        for (int k = 0; k < 5; k++) {
            help[k] = '-';
        }

        // Compara se as letras estão na posição correta da resposta.
        for (int j = 0; j < 5; j++) {
            if (try[j] == answer[j]) {
                help[j] = '*'; // Letra na posição correta
            } else {
                // Verifica se a letra da tentativa está em algum outro lugar da resposta.
                for (int l = 0; l < 5; l++) {
                    if (try[j] == answer[l]) {
                        help[j] = '+'; // Letra correta, mas na posição errada
                        break;
                    }
                }
            }
        }
        help[5] = '\0'; // Define que a posição 6 de help é o valor nulo

        printf("Ajuda: %s\n\n", help);

        if (strcmp(try, answer) == 0) { //Compara para saber se a resposta está correta
            printf("\nParabéns, você acertou a palavra!!\n");
            return 0;
        }
    }

    printf("\nVocê não conseguiu adivinhar a palavra. A resposta correta era: %s\n", answer);
    return 0; //Resposta caso sejam perdidas todas as 6 tentativas.
}

