using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;

namespace BenchmarkOldRegExVNewRegEx
{    
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.ColdStart, RuntimeMoniker.Net70, 1, 0)]
    public class BenchmarkRegEx
    {
        private const int iterations = 1000000;

        private readonly CheckRegexUsingStandardRegExInitialisedEachExecution _checkRegexUsingStandardRegExInitialisedEachExecution = new();
        

        private readonly CheckRegexUsingStandardRegExWithCompiler _checkRegexUsingStandardRegExWithCompiler = new();

        private readonly CheckRegexUsingStandardRegExWithoutCompiler _checkRegexUsingStandardRegExWithoutCompiler = new();

        private readonly CheckRegexUsingStandardStaticRegExWithoutCompiler _checkRegexUsingStandardStaticRegExWithoutCompiler = new();

        private readonly CheckRegexUsingStandardStaticRegExWithCompiler _checkRegexUsingStandardStaticRegExWithCompiler = new();

        private readonly CheckRegexUsingStandardStaticRegExWithLazyCompiler _checkRegexUsingStandardStaticRegExWithLazyCompiler = new();

        private readonly CheckRegexUsingCodeGenRegEx _checkRegexUsingCodeGenRegEx = new();

        private const string TestString = "https://stevetalkcode.co.uk";
        
        [Benchmark(Baseline = true, Description = "Using standard RegEx.IsMatch with new RegEx instance (not compiled) on each execution")]
        public void CheckRegexUsingNewRegEx1()
        {
            for (int counter = 0; counter < iterations; counter++)            
                _checkRegexUsingStandardRegExInitialisedEachExecution.IsUrlValid(TestString);
            
        }

        [Benchmark(Description = "Using standard RegEx.IsMatch with cached RegEx instance (not compiled)")]
        public void CheckRegexUsingNewRegEx2()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingStandardRegExWithoutCompiler.IsUrlValid(TestString);
        }

        [Benchmark(Description = "Using standard RegEx.IsMatch with cached RegEx instance (compiled)")]
        public void CheckRegexUsingNewRegEx3()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingStandardRegExWithCompiler.IsUrlValid(TestString);
        }
        
        [Benchmark(Description = "Using standard RegEx.IsMatch with static cached RegEx instance (not compiled)")]
        public void CheckRegexUsingNewRegEx4()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingStandardStaticRegExWithoutCompiler.IsUrlValid(TestString);
        }

        [Benchmark(Description = "Using standard RegEx.IsMatch with static cached RegEx instance (compiled)")]
        public void CheckRegexUsingNewRegEx5()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingStandardStaticRegExWithCompiler.IsUrlValid(TestString);
        }

        [Benchmark(Description = "Using standard RegEx.IsMatch with static lazily cached RegEx instance (compiled)")]
        public void CheckRegexUsingNewRegEx6()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingStandardStaticRegExWithLazyCompiler.IsUrlValid(TestString);
        }
        
        [Benchmark(Description = "Using source generated MatchIfValidUrl")]
        public void CheckRegexUsingNewRegEx7()
        {
            for (int counter = 0; counter < iterations; counter++)
                _checkRegexUsingCodeGenRegEx.IsUrlValid(TestString); 
        }
    }
}