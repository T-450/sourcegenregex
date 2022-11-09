namespace BenchmarkOldRegExVNewRegEx;

public class CheckRegexUsingStandardStaticRegExWithCompiler : IUrlValidator
{
    private static readonly Regex MyRegEx = new(RexExPatterns.UrlValidationPattern, RegexOptions.Compiled);
    public bool IsUrlValid(string url) => MyRegEx.IsMatch(url);
}