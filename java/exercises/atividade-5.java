import java.util.Scanner;

public class Program6 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro valor: ");
        double a = scanner.nextDouble();

        System.out.print("Digite o segundo valor: ");
        double b = scanner.nextDouble();

        System.out.print("Digite o terceiro valor: ");
        double c = scanner.nextDouble();

        double maior = (a + b + Math.abs(a - b)) / 2;
        maior = (maior + c + Math.abs(maior - c)) / 2;

        System.out.println("O maior valor é: " + maior);
    }
}
