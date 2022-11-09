using BenchmarkDotNet.Running;

namespace BenchmarkOldRegExVNewRegEx;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkRegEx>();
    }
}