using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine(Problem004a.Solution());
            stopwatch.Stop();
            Console.WriteLine( "Solved in " +stopwatch.ElapsedMilliseconds + "ms");
        }
    }
}
