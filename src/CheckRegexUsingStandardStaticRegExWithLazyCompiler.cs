namespace BenchmarkOldRegExVNewRegEx;

public class CheckRegexUsingStandardStaticRegExWithLazyCompiler : IUrlValidator
{
    private static readonly Lazy<Regex> MyRegEx = new(() => new(RexExPatterns.UrlValidationPattern, RegexOptions.Compiled));
    public bool IsUrlValid(string url) => MyRegEx.Value.IsMatch(url);
}