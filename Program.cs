using System;
using System.Threading;

public class Countdown
{
    public static void Main(string[] args)
    {
        Console.WriteLine("New Year's countdown\nEnter Countdown duration:\n");
        int countdown = Convert.ToInt32(Console.ReadLine());
{
            Thread.Sleep(1000);
            Console.WriteLine("");
            while (countdown > 0)
        {
            Console.WriteLine(countdown);
            Thread.Sleep(1000);
                countdown--;
        }

        Console.WriteLine("Happy New Year!");


    }
}
    }
