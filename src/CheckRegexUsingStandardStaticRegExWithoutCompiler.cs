namespace BenchmarkOldRegExVNewRegEx;
public class CheckRegexUsingStandardStaticRegExWithoutCompiler : IUrlValidator
{
    private static readonly Regex MyRegEx = new(RexExPatterns.UrlValidationPattern);
    public bool IsUrlValid(string url) => MyRegEx.IsMatch(url);
}