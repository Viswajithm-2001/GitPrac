using System;
using System.Globalization;
namespace Exception;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("Enter Number1");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Number1");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Result be"+num1/num2);

        }
        catch(FormatException e)
        {
            System.Console.WriteLine("Number format exception");
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("Divide by zero Exception");
        }
    }
}