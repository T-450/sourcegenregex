namespace BenchmarkOldRegExVNewRegEx;

public class CheckRegexUsingCodeGenRegEx : IUrlValidator
{
    public bool IsUrlValid(string url) => UrlValidator.IsValidUrl(url);
}