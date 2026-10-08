using session_12.Data;
using session_12.Models;

namespace session_12.Services;

public static class OrderingOperators
{
    private static readonly string[] MixedCaseWords = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
    private static readonly string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public static IEnumerable<Product> ProductsByName() =>
        ListGenerator.ProductsList.OrderBy(product => product.ProductName);

    public static IEnumerable<string> CaseInsensitiveWords() =>
        MixedCaseWords.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

    public static IEnumerable<Product> ProductsByStockDescending() =>
        ListGenerator.ProductsList.OrderByDescending(product => product.UnitsInStock);

    public static IEnumerable<string> DigitsByNameLengthThenAlphabetically() =>
        Digits.OrderBy(word => word.Length).ThenBy(word => word);

    public static IEnumerable<string> WordsByLengthThenCaseInsensitive() =>
        MixedCaseWords.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

    public static IEnumerable<Product> ProductsByCategoryThenPriceDescending() =>
        ListGenerator.ProductsList.OrderBy(product => product.Category)
            .ThenByDescending(product => product.UnitPrice);

    public static IEnumerable<string> WordsByLengthThenCaseInsensitiveDescending() =>
        MixedCaseWords.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

    public static IEnumerable<string> DigitsWithSecondLetterIReversed() =>
        Digits.Where(word => word.Length > 1 && word[1] == 'i').Reverse();
}
