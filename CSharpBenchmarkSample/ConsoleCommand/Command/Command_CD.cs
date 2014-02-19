using System;
using System.Collections.Generic;

namespace CSharpBenchmarkSample.ConsoleCommand.Command
{
    static class Command_CD
    {
        public static void ChangeDirectory(ref SampleDirectory applicationDirecotry, string targetDirectory)
        {
            SampleDirectory target;
            if (Enum.TryParse<SampleDirectory>(targetDirectory, true, out target))
            {
                ChangeDirectory(ref applicationDirecotry, target);
            }
            else
            {
                Console.WriteLine("No such directory");
            }
        }

        public static void ChangeDirectory(ref SampleDirectory applicationDirectory, SampleDirectory targetDirectory)
        {
            applicationDirectory = targetDirectory;
        }
    }
}
