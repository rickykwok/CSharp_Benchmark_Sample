using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpBrenchMark;

namespace CSharpBenchmarkSample.Strings
{
    class StringInterning : IRunningSample
    {
        private Random random = new Random();
        const Int32 count = 1000000000;

        public void Start()
        {
            ComparingStringWithoutInterning();
            ComparingStringWithInterning();
        }

        private void ComparingStringWithInterning()
        {
            using (new OperationTimer("ComparingStringWithInterning"))
            {
                string tempString = "STRING";
                tempString = String.Intern(tempString);
                string valueA = String.Intern(tempString);
                for (Int32 n = 0; n < count; n++)
                {
                    Object.ReferenceEquals(valueA, tempString);
                }
            }
        }

        private void ComparingStringWithoutInterning()
        {
            using (new OperationTimer("ComparingStringWithoutInterning"))
            {
                string tempString = "STRING";
                string valueA = tempString;
                for (Int32 n = 0; n < count; n++)
                {
                    valueA.Equals(tempString);
                }
            }
        }


    }
}
