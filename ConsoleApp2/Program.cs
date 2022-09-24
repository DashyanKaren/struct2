using BenchmarkDotNet.Running;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}
