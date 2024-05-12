using System;
namespace While;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Choose the crt option : ");
        string choice = "Y";
        while (choice != "N")
        {
            System.Console.WriteLine("Which city is capital of India?");
            System.Console.WriteLine("1. Chennai\n2. Delhi\n3. Mumbai\n4. Kolkata");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 2)
            {
                System.Console.WriteLine("Correct !");
            }
            else
            {
                System.Console.WriteLine("Incorrect !");
            }
            System.Console.WriteLine("Press Y to continue, Press N to close");
            choice = Console.ReadLine();
        } 
    }
}