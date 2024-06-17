import java.util.Scanner;

public class Program3 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Informe a idade: ");
        int idade = scanner.nextInt();

        System.out.print("Informe o grupo de risco (b-baixo, m-médio, a-alto): ");
        char grupoRisco = scanner.next().charAt(0);

        char codigoSeguro;

        if (idade >= 18 && idade <= 24) {
            if (grupoRisco == 'b') {
                codigoSeguro = '7';
            } else if (grupoRisco == 'm') {
                codigoSeguro = '8';
            } else if (grupoRisco == 'a') {
                codigoSeguro = '9';
            } else {
                codigoSeguro = '-';
            }
        } else if (idade >= 25 && idade <= 40) {
            if (grupoRisco == 'b') {
                codigoSeguro = '4';
            } else if (grupoRisco == 'm') {
                codigoSeguro = '5';
            } else if (grupoRisco == 'a') {
                codigoSeguro = '6';
            } else {
                codigoSeguro = '-';
            }
        } else if (idade >= 41 && idade <= 70) {
            if (grupoRisco == 'b') {
                codigoSeguro = '1';
            } else if (grupoRisco == 'm') {
                codigoSeguro = '2';
            } else if (grupoRisco == 'a') {
                codigoSeguro = '3';
            } else {
                codigoSeguro = '-';
            }
        } else {
            codigoSeguro = '-';
        }

        if (codigoSeguro != '-') {
            System.out.println("O código do seguro é: " + codigoSeguro);
        } else {
            System.out.println("Não é possível determinar o código do seguro.");
        }
    }
}
