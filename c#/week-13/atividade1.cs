using System;

class Program
{
    static void Main()
    {
        double[] velocidades = new double[60] 
        {
            0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 
            20, 22, 24, 26, 28, 30, 32, 34, 36, 38,
            40, 42, 44, 45, 46, 47, 48, 49, 50, 51, 
            51, 50, 49, 48, 47, 46, 45, 44, 43, 42, 
            41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 
            30, 28, 26, 24, 22, 20, 18, 16, 14, 12;
        };

        int maiorPeriodoSemDiminuir = 0;
        int periodoAtualSemDiminuir = 0;

        int inicioFrenagemAbrupta = 0;
        double maiorFrenagem = 0;

        double maiorAceleracao = 0;
        int instanteMaiorAceleracao = 0;

        int maiorPeriodoVelocidadeConstante = 0;
        int periodoAtualConstante = 0;


        for (int i = 1; i < velocidades.Length; i++)
        {
            if (velocidades[i] >= velocidades[i - 1])
            {
                periodoAtualSemDiminuir++;
                if (periodoAtualSemDiminuir > maiorPeriodoSemDiminuir)
                {
                    maiorPeriodoSemDiminuir = periodoAtualSemDiminuir;
                }
            }
            else
            {
                periodoAtualSemDiminuir = 0; 
            }
        }

        for (int i = 1; i < velocidades.Length; i++)
        {
            double frenagemAtual = velocidades[i - 1] - velocidades[i];
            if (frenagemAtual > maiorFrenagem)
            {
                maiorFrenagem = frenagemAtual;
                inicioFrenagemAbrupta = i - 1;
            }
        }

        
        for (int i = 1; i < velocidades.Length; i++)
        {
            double aceleracaoAtual = velocidades[i] - velocidades[i - 1]; 
            if (aceleracaoAtual > maiorAceleracao)
            {
                maiorAceleracao = aceleracaoAtual;
                instanteMaiorAceleracao = i - 1;
            }
        }

        for (int i = 1; i < velocidades.Length; i++)
        {
            if (velocidades[i] == velocidades[i - 1])
            {
                periodoAtualConstante++;
                if (periodoAtualConstante > maiorPeriodoVelocidadeConstante)
                {
                    maiorPeriodoVelocidadeConstante = periodoAtualConstante;
                }
            }
            else
            {
                periodoAtualConstante = 0; 
            }
        }

        Console.WriteLine("Maior período sem diminuir a velocidade: " + maiorPeriodoSemDiminuir + " segundos.");
        Console.WriteLine("Instante de frenagem mais abrupta: " + inicioFrenagemAbrupta + " segundos.");
        Console.WriteLine("Maior aceleração positiva: " + maiorAceleracao + " m/s², iniciada no segundo " + instanteMaiorAceleracao + ".");
        Console.WriteLine("Maior período com velocidade constante: " + maiorPeriodoVelocidadeConstante + " segundos.");
    }
}
