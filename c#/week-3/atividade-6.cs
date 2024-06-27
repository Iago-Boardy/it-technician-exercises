using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite seu salario bruto:");
        double salary = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Qual o valor da prestação:");
        double prestacao = double.Parse(Console.ReadLine());
        
        if (salary * 1.3 < prestacao){
            Console.WriteLine("Não sera possivel efetuar a prestação");
            
        } else {
            Console.WriteLine("Prestação aceita");
        }
