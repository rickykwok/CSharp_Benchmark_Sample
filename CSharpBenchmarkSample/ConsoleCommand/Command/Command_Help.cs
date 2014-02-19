using System;

namespace CSharpBenchmarkSample.ConsoleCommand.Command
{
    static class Command_Help
    {
        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("{0,-20}{1,-20}", "Command", "Description");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("{0,-20}{1,-20}", "CD ", "Change sample directory CD <DIRECTORY>|<SAMPLE_NO>");
            Console.WriteLine("{0,-20}{1,-20}", "START ", "Start running sample");
            Console.WriteLine("{0,-20}{1,-20}", "LIST", "List directories in root or samples in directory");
            Console.WriteLine("{0,-20}{1,-20}", "EXIT", "Exit application");
            Console.WriteLine();
        }
    }
}
