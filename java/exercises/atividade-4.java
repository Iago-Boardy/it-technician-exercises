import java.util.Scanner;

public class Program4 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Calculadora Básica");
            System.out.println("1 – Somar dois números");
            System.out.println("2 – Subtrair dois números");
            System.out.println("3 – Multiplicar dois números");
            System.out.println("4 – Dividir dois números");
            System.out.println("5 – Sair");
            System.out.print("Digite uma opção: ");

            int opcao = scanner.nextInt();

            if (opcao == 5) {
                System.out.println("Encerrando a calculadora.");
                break;
            }

            System.out.print("Digite o primeiro número: ");
            double num1 = scanner.nextDouble();

            System.out.print("Digite o segundo número: ");
            double num2 = scanner.nextDouble();

            double resultado = 0;

            switch (opcao) {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0) {
                        resultado = num1 / num2;
                    } else {
                        System.out.println("Divisão por zero não é possível.");
                        continue;
                    }
                    break;
                default:
                    System.out.println("Opção inválida.");
                    continue;
            }

            System.out.println("Resultado: " + resultado);
        }
    }
}
