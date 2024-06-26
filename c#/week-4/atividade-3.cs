using System;
using System.Collections.Generic;

public class PesquisaAltura
{
    public static void Main(string[] args)
    {
        double altura, totala = 0, totalam = 0;
        int sexo, totalm = 0, totalh = 0;
        List<double> alturas = new List<double>();
        List<int> sexos = new List<int>();
        
        while (true) {
            Console.WriteLine("Digite a altura da pessoa (ou 0 ou negativo para sair):");
            altura = double.Parse(Console.ReadLine());
            
            if (altura <= 0) {
                break;
            }
            
            Console.WriteLine("Digite o sexo da pessoa (0=masc, 1=fem):");
            sexo = int.Parse(Console.ReadLine());
            
            alturas.Add(altura);
            sexos.Add(sexo);
            
            totala += altura;
            if (sexo == 1) {
                totalam += altura;
                totalm++;
            } else if (sexo == 0) {
                totalh++;
            }
        }
        
        if (alturas.Count == 0) {
            Console.WriteLine("Nenhum dado foi inserido.");
            return;
        }

        double maiora = alturas[0];
        double menora = alturas[0];
        
        for (int i = 1; i < alturas.Count; i++) {
            if (alturas[i] > maiora) {
                maiora = alturas[i];
            }
            if (alturas[i] < menora) {
                menora = alturas[i];
            }
        }

        double mediaam = totalm > 0 ? totalam / totalm : 0;
        double mediaap = totala / alturas.Count;
        double percentualh = (totalh / (double)alturas.Count) * 100;
        
        Console.WriteLine($"Maior altura: {maiora:F2}\nMenor altura: {menora:F2}\nMédia de altura das mulheres: {mediaam:F2}\nMédia de altura da população: {mediaap:F2}\nPercentual de homens na população: {percentualh:F2}%");
    }
}
