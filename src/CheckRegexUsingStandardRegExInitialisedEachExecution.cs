namespace BenchmarkOldRegExVNewRegEx;

public class CheckRegexUsingStandardRegExInitialisedEachExecution : IUrlValidator
{
    /// <summary>
    /// You wou
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public bool IsUrlValid(string url)
    {
        var regEx = new Regex(RexExPatterns.UrlValidationPattern);
        return regEx.IsMatch(url);
    }
}