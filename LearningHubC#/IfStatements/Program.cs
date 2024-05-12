using System;
namespace IfStatements;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Mark : ");
        char mark = char.Parse(Console.ReadLine());
        if(mark == 'A')
        {
            System.Console.WriteLine("Grade A denotes 9 Points");
        }
        else if(mark == 'B')
        {
            System.Console.WriteLine("Grade A denotes 8 Points");
        }
        else if(mark == 'C')
        {
            System.Console.WriteLine("Grade A denotes 7 Points");
        }
        else if(mark == 'D')
        {
            System.Console.WriteLine("Grade A denotes 6 Points");
        }
        else
        {
            System.Console.WriteLine("This is not valid Grade");
        }
    }
}