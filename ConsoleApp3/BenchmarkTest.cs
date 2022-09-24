
using BenchmarkDotNet.Attributes;

public class BenchmarkTest
{
    [Benchmark]
    public void WithStruct()
    {
        MyStruct[] arr = new MyStruct[200];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new MyStruct();
        }
    }

    [Benchmark]
    public void WithClass()
    {
        MyClass[] arr = new MyClass[200];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new MyClass();
        }
    }
}