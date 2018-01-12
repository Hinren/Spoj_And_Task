using System;

public class Test
{
    public static void Main()
    {
        string y;
        while (((y = Console.ReadLine())) != null)
        {
            double a, b, c;
            a = double.Parse(y.Split()[0]);
            b = double.Parse(y.Split()[1]);
            c = double.Parse(y.Split()[2]);

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("0");
            }

        }
    }
}