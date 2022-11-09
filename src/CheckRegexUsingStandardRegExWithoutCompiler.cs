namespace BenchmarkOldRegExVNewRegEx;
public class CheckRegexUsingStandardRegExWithoutCompiler : IUrlValidator
{
    private readonly Regex _regEx;
    public CheckRegexUsingStandardRegExWithoutCompiler()
    {
        _regEx = new Regex(RexExPatterns.UrlValidationPattern);
    }
    public bool IsUrlValid(string url) => _regEx.IsMatch(url);
}