using BenchmarkDotNet.Running;

namespace algorithms_effectiveness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortingAlgorithms>();
        }
    }
}
