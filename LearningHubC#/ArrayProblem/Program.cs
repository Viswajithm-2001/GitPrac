using System;
namespace ArrayProblem;
class Program
{
    static void ReverseSort(int[] arr)
    {
        int n = arr.Length;
        for(int i=0;i<n-1;i++)
        {
            for(int j=0;j<n-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
    }
    static void Sort(int[] arr)
    {
        int n = arr.Length;
        for(int i=0;i<n-1;i++)
        {
            for(int j=0;j<n-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = new int[5];
        System.Console.WriteLine("Enter 5 number s to store in array");
        for(int i=0;i<5;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Sort(arr);
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine(arr[i]);
        }
        //for 2nd problem
        arr = new int[10];
        int oddCount =0,evenCount=0;
        for(int i=0;i<10;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if(arr[i]%2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        int[] oddArray = new int[oddCount];
        int[] evenArray = new int[evenCount];
        Sort(evenArray);
        ReverseSort(oddArray);
        System.Console.WriteLine("Even numbers : ");
        for(int i=0;i<evenArray.Length;i++)
        {
            System.Console.WriteLine(evenArray[i]);
        }
        System.Console.WriteLine("Odd numbers");
        for(int i=0;i<oddArray.Length;i++)
        {
            System.Console.WriteLine(oddArray[i]);
        }

    }
}