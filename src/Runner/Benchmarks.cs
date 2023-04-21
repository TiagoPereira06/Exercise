using BenchmarkDotNet.Attributes;
using Exercise;
using static System.Int32;

namespace BenchmarkRunner;

[MemoryDiagnoser]
public class Benchmarks
{
    private int[] data;

    [Params(2, 10, 1000, 10000)]
    public int InputSize;

    [GlobalSetup]
    public void Setup()
    {
        data = new int[InputSize];
        var randNum = new Random();
        for (var i = 0; i < InputSize; i++)
        {
            data[i] = randNum.Next(MinValue, MaxValue);
        }
    }

    [Benchmark]
    public int Itr1() => MaxProductMultipleOfThreeItr1.MaxProductMultipleOfThree(data);
    
    [Benchmark]
    public int Itr2() => MaxProductMultipleOfThreeItr2.MaxProductMultipleOfThree(data);
}