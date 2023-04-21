namespace BenchmarkRunner;

class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkDotNet.Running.BenchmarkRunner.Run<Benchmarks>();
    }
}