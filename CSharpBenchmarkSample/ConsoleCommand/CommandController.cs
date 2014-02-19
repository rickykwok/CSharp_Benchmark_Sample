using System;
using CSharpBenchmarkSample.ConsoleCommand.Command;

namespace CSharpBenchmarkSample.ConsoleCommand
{
    class CommandController
    {
        private static SampleDirectory currentDirectory = SampleDirectory.Root;

        public static void ReadCommand()
        {
            while (true)
            {
                Console.WriteLine("Please enter command (/? for Help)");
                Console.Write("{0} : ", currentDirectory.ToString());
                DecomposeCommand(Console.ReadLine());
                Console.WriteLine();
            }
        }

        private static void DecomposeCommand(string readText)
        {
            string[] command = readText.Split(' ');
            if (command.Length == 0)
                return;
            if (string.IsNullOrEmpty(command[0]))
                return;
            command[0] = command[0].ToUpper();
            switch (command[0])
            {
                case "/?":
                case "HELP":
                    Command_Help.Help();
                    break;
                case "LIST":
                    Command_List.List(currentDirectory);
                    break;
                case "CD..":
                case "ROOT":
                    Command_CD.ChangeDirectory(ref currentDirectory, SampleDirectory.Root);
                    break;
                case "CD":
                    if (command.Length != 2)
                    {
                        Console.WriteLine("CD <DIRECTORY>");
                        return;
                    }
                    Command_CD.ChangeDirectory(ref currentDirectory, command[1]);
                    break;
                case "START":
                    if (command.Length != 2)
                    {
                        Console.WriteLine("START <SAMPLE>");
                        return;
                    }
                    Command_Start.StartTask(currentDirectory, command[1]);
                    break;
                default :
                    Console.WriteLine("No such command");
                    break;
            }
         
        }
    }
}
