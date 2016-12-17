using System;

public class Funcs
{

    public static void useFunc()
    {
        Console.WriteLine("using Func");
        Console.WriteLine(Calculate(1,2,add));
        Console.WriteLine(Calculate(1,2,subtract));
        Console.WriteLine(Calculate(2,3,(a,b) => {
            return (decimal) a * b;
        }));

    }

    private static decimal subtract(int arg1, int arg2)
    {
        return (decimal) arg1 - arg2;
    }

    private static decimal add(int arg1, int arg2)
    {
        return (decimal) arg1 + arg2;
    }

    public static decimal Calculate(int a, int b, Func<int, int, decimal> f)
    {
        return f.Invoke(a, b);
    }
}