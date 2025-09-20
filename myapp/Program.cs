using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Skriv ditt namn: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Du måste skriva in ett namn!");
        }
        else
        {
            SayHello(name);
        }
    }

    static void SayHello(string name)
    {
        Console.WriteLine($"Hej {name}, välkommen till programmet!");
    }
}
