using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBenchmarkSample.Strings
{
    class _SampleList: ISampleList
    {
        private List<string> list_Dir = new List<string>() { 
            "1. StringInterning"
        };

        public void List()
        {
            foreach (var s in list_Dir)
            {
                Console.WriteLine(s);
            }
        }

        public bool GetSampleNameBySampleNumber(int sampleNumber, out string sampleName)
        {
            switch (sampleNumber)
            {
                case 1:
                    sampleName = "StringInterning";
                    return true;
                default:
                    sampleName = string.Empty;
                    return false;
            }
        }
    }
}
