using System;

namespace Operators;
class Program
{

    public static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3;
        System.Console.WriteLine("Enter 1. Add\n2. Subtract\n3. Multiplication\n4. Division\n5. Modulus");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine(num1 + num2);
                break;
            }
            case 2:
            {
                System.Console.WriteLine(num1 - num2);

                break;
            }
            case 3:
            {
                System.Console.WriteLine(num1 * num2);

                break;
            }
            case 4:
            {
                System.Console.WriteLine(num1 / num2);

                break;
            }
            case 5:
            {
                System.Console.WriteLine(num1 % num2);

                break;
            }
            default:
            {
                break;
            }
        }

        System.Console.WriteLine("_________________________________");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Greater number is : ");
        if(num1>=num2 && num1>=num3)
        {
            System.Console.WriteLine(num1);
        }
        else if(num2>=num1 && num2>=num3)
        {
            System.Console.WriteLine(num1);
        }
        else if(num3>=num2 && num3>=num2)
        {
            System.Console.WriteLine(num1);
        }

    }
}