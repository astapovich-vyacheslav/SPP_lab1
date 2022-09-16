using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMethods tests = new TestMethods();

            int result;

            Tracer tracer1 = new Tracer(
                //System.Reflection.MethodBase.GetCurrentMethod().Name,
                "FastPower",
                tests.GetType().ToString());
            tracer1.StartTrace();
            result = tests.FastPower(7, 53);
            tracer1.StopTrace();
            Console.WriteLine($"Fast method: {tracer1.GetTraceResult().Time}");

            Tracer tracer2 = new Tracer(
                //System.Reflection.MethodBase.GetCurrentMethod().Name,
                "SlowPower",
                tests.GetType().ToString());
            tracer2.StartTrace();
            result = tests.SlowPower(7, 52);
            tracer2.StopTrace();
            Console.WriteLine($"Slow method: {tracer2.GetTraceResult().Time}");

        }
    }
}
