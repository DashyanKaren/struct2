using BenchmarkDotNet.Running;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}
