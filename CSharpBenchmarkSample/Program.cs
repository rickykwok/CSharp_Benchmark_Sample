using System;
using System.Text;
using CSharpBenchmarkSample.Generic;
using CSharpBenchmarkSample.ConsoleCommand;
using System.IO;

namespace CSharpBenchmarkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CSharp BenchmarkSample");
            Console.WriteLine("Version {0}",
               System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine();

            CommandController.ReadCommand();
        }
    }
}
