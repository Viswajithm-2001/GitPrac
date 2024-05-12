using System;
namespace Enumer;

class Program
{
    public enum Calc
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Division
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Calculator");
        System.Console.WriteLine("Press 1 to add two number\nPress 2 to subtract two number\nPress 3 to multiply two number\nPress 4 to divide two number");
        int n = int.Parse(Console.ReadLine());


        switch ((Calc)n)
        {
            case Calc.Addition:
                {
                    System.Console.WriteLine("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Result : ");
                    System.Console.WriteLine(num1 + num2);
                    break;
                }
            case Calc.Subtraction:
                {
                    System.Console.WriteLine("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Result : ");
                    System.Console.WriteLine(num1 + num2);
                    break;
                }
            case Calc.Multiplication:
                {
                    System.Console.WriteLine("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Result : ");
                    System.Console.WriteLine(num1 + num2);
                    break;
                }
            case Calc.Division:
                {
                    System.Console.WriteLine("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Result : ");
                    System.Console.WriteLine(num1 + num2);
                    break;
                }
        }

    }
}