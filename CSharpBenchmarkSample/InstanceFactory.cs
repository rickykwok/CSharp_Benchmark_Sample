using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CSharpBenchmarkSample
{
    static class InstanceFactory
    {
        public static Object CreateInstance(Type t)
        {
            Object o = null;
            try
            {
                o = Activator.CreateInstance(t);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            return o;
        }
    }
}
