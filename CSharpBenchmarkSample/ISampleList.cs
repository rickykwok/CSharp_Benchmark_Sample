using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBenchmarkSample
{
    interface ISampleList
    {
        void List();
        bool GetSampleNameBySampleNumber(int sampleNumber, out string sampleName);
    }
}
