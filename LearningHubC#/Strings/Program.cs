using System;
namespace Strings;

class Program
{
    public static void Main(string[] args)
    {
        string str = "Syncfusion";
        //Displaying odd number of character
        for(int i=0;i<str.Length;i++)
        {
            if(i%2 != 0)
            {
                System.Console.WriteLine(str[i]);
            }
        }
        //replace the character n with N
        string temp = "";
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]=='n')
            {
                temp+='N';
            }
            else{
                temp+=str[i];
            }
        }
        //reverse printing
        System.Console.WriteLine(temp);
        for(int i= temp.Length-1;i>=0;i--)
        {
            System.Console.WriteLine(temp[i]);
        }
        //calculate length of string
        System.Console.WriteLine(temp.Length);
        //Get the two string from user and concatenate the first 4 characters of first string and last 3 characters of second string
        string str1 = "Computer";
        string str2 = "Science";
        int str1Count = 0;
        int str2Count = 0;
        string newStr = "";
        for(int i=0;i<str1.Length;i++)
        {
            if(str1Count>4)
            {
                break;
            }
            newStr+=str1[i];
        }
        for(int i=0;i<str2.Length;i++)
        {
            if(str2Count>3)
            {
                break;
            }
            newStr+=str1[i];
        }
        //split
        string val = "Chennai,Trichy,Mumbai";
        string[] arr = val.Split(",");
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine(arr[i]);
        }

    }
}