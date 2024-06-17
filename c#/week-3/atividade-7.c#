using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite seu saldo médio:");
        double saldom = double.Parse(Console.ReadLine());
        
        if (saldom < 0) {
            Console.WriteLine ("saldo médio invalido:");
        } else if ((saldom >= 0) && (saldom <= 500)){
            Console.WriteLine ("Não possui nenhum credito");
        } else if ((saldom >= 501) && (saldom <= 1000)) {
            Console.WriteLine("30% do valor do saldo médio");
        } else if ((saldom >= 1001) && (saldom <= 3000)) {
            Console.WriteLine("40% do valor do saldo médio");
        } else {
            Console.WriteLine("50% do valor do saldo médio");
        }
