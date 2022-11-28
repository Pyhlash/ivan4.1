using System;
using static System.Console;
public class MainClass
{
  public static void Main()
  {
    int month;
    
    restart:
    WriteLine("Введите номер месяца");
    month = int.Parse(Console.ReadLine());
       
        if(1<=month||12<=month)
        {
            
            int lY = 2024;
            int nLY = 2024;
            Console.Write("год високосный?1 - да");
            Console.WriteLine($"в месяце {DateTime.DaysInMonth(Console.ReadLine() == "1" ? nLY : lY, month)} дней");
            goto restart;
        }
       
        else
        {
            WriteLine("Такого месяца не существует");
            goto restart;
        }


  }
}