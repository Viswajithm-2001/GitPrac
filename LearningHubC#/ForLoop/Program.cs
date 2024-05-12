using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter 10 number to print");
        int val=0;
        for(int i=0;i<10;i++)
        {
            val += int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("The Sum of 10 number is : "+val);
        System.Console.WriteLine("The average is : "+(val/10));
    }
}