using System;
using System.Diagnostics;
using System.Linq;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowDotnetProcess();
            TestDelegate();
            TestFunctions();
            TestActions();



        }

        static void ShowDotnetProcess()
        {
            var processes = Process.GetProcesses();
            var process = processes.Where(p => p.ProcessName == "dotnet").First();
            Console.WriteLine(process.ToString());
        }

        static void TestDelegate()
        {
            Delegates.useDelegate();
            
        }

        static void TestFunctions()
        {
            Funcs.useFunc();
        }

        static void TestActions()
        {
            Actions.useActions();
        }
    }
}
