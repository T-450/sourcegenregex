namespace BenchmarkOldRegExVNewRegEx;
public static partial class UrlValidator
{
    [GeneratedRegex(RexExPatterns.UrlValidationPattern, RegexOptions.CultureInvariant, matchTimeoutMilliseconds: 1000)]
    private static partial Regex MatchIfValidUrl();
    public static bool IsValidUrl(string url) => MatchIfValidUrl().IsMatch(url);
}

public partial class OtherUrlValidator
{
    [GeneratedRegex(RexExPatterns.UrlValidationPattern, RegexOptions.CultureInvariant, matchTimeoutMilliseconds: 1000)]
    private static partial Regex MatchIfValidUrl();
    public static bool IsValidUrl(string url) => MatchIfValidUrl().IsMatch(url);
}