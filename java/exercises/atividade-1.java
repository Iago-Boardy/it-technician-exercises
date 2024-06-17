import java.util.Scanner;

public class Program1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Informe o número de litros vendidos: ");
        double litrosVendidos = scanner.nextDouble();

        System.out.print("Informe o tipo de combustível (E-etanol, G-gasolina): ");
        char tipoCombustivel = scanner.next().charAt(0);

        double precoLitro;
        if (tipoCombustivel == 'G') {
            precoLitro = 3.99;
        } else if (tipoCombustivel == 'E') {
            precoLitro = 3.19;
        } else {
            System.out.println("Tipo de combustível inválido.");
            return;
        }

        double valorAPagar = litrosVendidos * precoLitro;
        System.out.println("Valor a ser pago pelo cliente: R$ " + valorAPagar);
    }
}

