using System;

namespace CSharpBenchmarkSample.ConsoleCommand.Command
{
    static class Command_List
    {
        public static void List(SampleDirectory currentDirectory)
        {
            Console.WriteLine();
            if (currentDirectory == SampleDirectory.Root)
            {
                Console.WriteLine("Current directory under \"Root\"");
                foreach (SampleDirectory dir in Enum.GetValues(typeof(SampleDirectory)))
                {
                    if (dir != SampleDirectory.Root)
                    {
                        Console.WriteLine(dir.ToString());
                    }
                }
            }
            else
            {
                string sampleListFile = "CSharpBenchmarkSample." + currentDirectory.ToString() + "._SampleList";
                Console.WriteLine("Current sample(s) under \"{0}\" :", currentDirectory.ToString());
                ISampleList sampleList = (ISampleList)InstanceFactory.CreateInstance(Type.GetType(sampleListFile));
                sampleList.List();
            }
        }

    }
}
