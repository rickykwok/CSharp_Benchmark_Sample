using System;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpBenchmarkSample.ConsoleCommand.Command
{
    static class Command_Start
    {
        public static void StartTask(SampleDirectory currentDirectory, string sampleTask)
        {
            if (currentDirectory == SampleDirectory.Root)
            {
                Console.WriteLine("There should be no sample under Root directory");
                return;
            }
            int sampleTaskNo;
           
            if (Int32.TryParse(sampleTask, out sampleTaskNo))
            {
                string sampleListFile = "CSharpBenchmarkSample." + currentDirectory.ToString() + "._SampleList";
                ISampleList sampleList = (ISampleList)InstanceFactory.CreateInstance(Type.GetType(sampleListFile));
                sampleList.GetSampleNameBySampleNumber(sampleTaskNo, out sampleTask);
            }
            string sampleTaskPath = "CSharpBenchmarkSample." + currentDirectory.ToString() + "." + sampleTask;
            try
            {
                IRunningSample sample = (IRunningSample)InstanceFactory.CreateInstance(Type.GetType(sampleTaskPath));
                Console.WriteLine();
                Console.WriteLine("Starting Task {0}", sampleTask);
                Start(sample);
                Console.WriteLine("End Task");
            }
            catch (Exception)
            {
                Console.WriteLine("No such sample {0} under \"{1}\"", sampleTask, currentDirectory.ToString()); 
            }
         
             
        }

        private static void Start(IRunningSample sampleTask)
        {
            Task task = new Task(sampleTask.Start);
            task.RunSynchronously();
        }
    }
}
