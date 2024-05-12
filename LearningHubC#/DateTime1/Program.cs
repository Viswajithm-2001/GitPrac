using System;
namespace DateTime1;

class Program
{
    public static void Main(string[] args)
    {
        string[] months = new string[]{"Jan","Feb","Mar","Apr","May","Jun","July","Aug","Sept","Oct","Nov","Dec"};
        DateTime current = DateTime.Now;
        System.Console.WriteLine(months[current.Month-1]);
        DateTime newDate = current;
        System.Console.WriteLine(newDate.AddDays(-3).ToString("dd/MM/yyyy"));
        System.Console.WriteLine(current.ToString("dd/MM/yyyy hh:ss tt"));
    }
}