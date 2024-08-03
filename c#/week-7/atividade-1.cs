using System;
using System.Collections.Generic;

public class Atividade1
{
    public static void Main(string[] args)
    {
        List<int> ages = new List<int>();
        string[] names = {"Celeste", "Camila", "Cibele"};
        
        for (int i = 0; i < 3; i++) {
            Console.Write("Write an age of the sister: ");
            int sisAge = int.Parse(Console.ReadLine());

            if (sisAge <= 5 || sisAge >= 100) {
                //throw new ArgumentException("Write only ages higher than 5 and lower than 100!"); Here we can literally throw an error with a message if we want to.
                Console.WriteLine("Write only ages higher than 5 and lower than 100!");
                Environment.Exit(1);
            }
            
            if (ages.Contains(sisAge)) {
                Console.WriteLine("Age already exists!");
                i--; //We can use i-- to repeat the loop where we are.
            } else {
                ages.Add(sisAge);
            }
            
        }
        
        Console.WriteLine();
        ages.Sort();
        
        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"The age of {names[i]} is {ages[i]}y.");
        }
        
        Console.WriteLine($"\nSo the age of Camila is {ages[1]}!");
    }
}
