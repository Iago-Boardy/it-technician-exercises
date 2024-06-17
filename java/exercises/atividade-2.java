import java.util.Scanner;

public class Program2 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Informe o número de horas-extras: ");
        int horasExtras = scanner.nextInt();

        System.out.print("Informe o número de horas de faltas: ");
        int horasFaltas = scanner.nextInt();

        int h = horasExtras - (2 * horasFaltas / 3);
        double premio = 0;

        if (h > 2400) {
            premio = 500.0;
        } else if (h > 1800) {
            premio = 400.0;
        } else if (h > 1200) {
            premio = 300.0;
        } else if (h > 600) {
            premio = 200.0;
        } else {
            premio = 100.0;
        }

        System.out.println("O valor da gratificação é: R$ " + premio);
    }
}
