namespace BenchmarkOldRegExVNewRegEx;
public class CheckRegexUsingStandardRegExWithCompiler : IUrlValidator
{
    private readonly Regex _regEx;
    public CheckRegexUsingStandardRegExWithCompiler()
    {
        _regEx = new Regex(RexExPatterns.UrlValidationPattern, RegexOptions.Compiled);
    }
    public bool IsUrlValid(string url) => _regEx.IsMatch(url);
}