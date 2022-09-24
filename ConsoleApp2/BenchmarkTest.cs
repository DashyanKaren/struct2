
using BenchmarkDotNet.Attributes;

public class BenchmarkTest
{
    MyClass myClass = new MyClass();
    MyStruct myStruct = new MyStruct();

    public void WithStruct(MyStruct myStruct)
    {
        myStruct.Number1 += myStruct.Number2;
    }

    public void WithStructIN(in MyStruct myStruct)
    {
        var x = myStruct.Number1 + myStruct.Number2;
    }

    public void WithClass(MyClass myClass)
    {
        myClass.Number1 += myClass.Number2;
    }

    [Benchmark]
    public void StructTest()
    {
        WithStruct(myStruct);
    }

    [Benchmark]
    public void StructTestIn()
    {
        WithStructIN(myStruct);
    }

    [Benchmark]
    public void ClassTest()
    {
        WithClass(myClass);
    }
}