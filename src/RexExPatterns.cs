namespace BenchmarkOldRegExVNewRegEx;

public static class RexExPatterns
{
    public const string UrlValidationPattern =
        @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";
}