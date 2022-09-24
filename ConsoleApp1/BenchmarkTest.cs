using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class BenchmarkTest
{
    [Benchmark]
    public void StructTest()
    {
        MyStruct obs = new MyStruct();
        obs.Number1 = 20;
        obs.Number2 = 30;
        var result = obs.Number1 = obs.Number2;
    }

    [Benchmark]
    public void ClassTest()
    {
        MyClass obc = new MyClass();
        obc.Number1 = 20;
        obc.Number2 = 30;
        var result = obc.Number1 = obc.Number2;
    }
}

