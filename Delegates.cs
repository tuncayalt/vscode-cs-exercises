using System;

public class Delegates
{
    public delegate decimal MyDelegate (int a, int b);
    public static void useDelegate()
    {
        Console.WriteLine("using Delegate");
        Console.WriteLine(Calculate(1, 2, Add));
        Console.WriteLine(Calculate(1, 2, Subtract));
        Console.WriteLine(Calculate(3, 5, (a, b) => {
            // inline function for multiplication
            return (decimal) a * b;
        }));
    }
    private static decimal Subtract(int a, int b)
    {
        return (decimal) a - b;
    }

    private static decimal Add(int a, int b)
    {
        return (decimal) a + b;
    }

    static decimal Calculate (int a, int b, MyDelegate dl)
    {
        return dl(a, b);
    }
}