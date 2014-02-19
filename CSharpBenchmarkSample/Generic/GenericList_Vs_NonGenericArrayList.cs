/*
 *  License - Jeffery Richter
 *  Sample in CLR via C#
 */ 

using System;
using System.Collections.Generic;
using CSharpBrenchMark;
using System.Collections;

namespace CSharpBenchmarkSample.Generic
{
    class GenericList_Vs_NonGenericArrayList : IRunningSample
    {
        const Int32 count = 10000000;

        public void Start()
        {
            ValueTypePerfTest();
            ReferenceTypePerfTest();
        }

        private void ValueTypePerfTest()
        {
            using (new OperationTimer("List<Int32>"))
            {
                List<Int32> l = new List<Int32>();
                for (Int32 n = 0; n < count; n++)
                {
                    l.Add(n); // No boxing
                    Int32 x = l[n]; // No unboxing
                }
                l = null; // Make sure this gets garbage collected
            }
            using (new OperationTimer("ArrayList of Int32"))
            {
                ArrayList a = new ArrayList();
                for (Int32 n = 0; n < count; n++)
                {
                    a.Add(n); // Boxing
                    Int32 x = (Int32)a[n]; // Unboxing
                }
                a = null; // Make sure this gets garbage collected
            }
        }

        private void ReferenceTypePerfTest()
        {
            using (new OperationTimer("List<String>"))
            {
                List<String> l = new List<String>();
                for (Int32 n = 0; n < count; n++)
                {
                    l.Add("X"); // Reference copy
                    String x = l[n]; // Reference copy
                }
                l = null; // Make sure this gets garbage collected
            }
            using (new OperationTimer("ArrayList of String"))
            {
                ArrayList a = new ArrayList();
                for (Int32 n = 0; n < count; n++)
                {
                    a.Add("X"); // Reference copy
                    String x = (String)a[n]; // Cast check & reference copy
                }
                a = null; // Make sure this gets garbage collected
            }
        }

    }
}
