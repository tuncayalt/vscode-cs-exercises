using System;
using System.Reflection;

public class Actions
{
    public static void useActions()
    {
        Console.WriteLine("using Action");
        Calculate(1,2,add);
        Calculate(1,2,subtract);
        Calculate(1,2, (a,b) => {
            Console.WriteLine(a * b);
        });
    }

    private static void add (int a, int b)
    {
        Console.WriteLine(a + b);
    }

    private static void subtract (int a, int b)
    {
        Console.WriteLine(a - b);
    }

    private static void Calculate(int a, int b, Action<int,int> MyAction)
    {
        MyAction.Invoke(a, b);
    }
}