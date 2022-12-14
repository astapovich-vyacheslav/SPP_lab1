using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_lab1
{
    public class TraceResult
    {
        public double Time { get; set; }
        public string MethodName { get; set; }
        public string ClassName { get; set; }

        public TraceResult(double time, string methodName, string className)
        {
            Time = time;
            MethodName = methodName;
            ClassName = className;
        }
        public void PrintResult()
        {
            Console.WriteLine(Time);
            Console.WriteLine(MethodName);
            Console.WriteLine(ClassName);
        }
    }
}
