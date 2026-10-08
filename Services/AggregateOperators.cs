using session_12.Data;
using session_12.Utilities;

namespace session_12.Services;

public static class AggregateOperators
{
    private static readonly int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    public static int CountOddNumbers() => Numbers.Count(number => number % 2 != 0);

    public static IEnumerable<(string CustomerName, int OrderCount)> OrderCountPerCustomer() =>
        ListGenerator.CustomersList.Select(customer => (customer.CustomerName, customer.Orders.Length));

    public static IEnumerable<(string Category, int ProductCount)> ProductCountPerCategory() =>
        ListGenerator.ProductsList
            .GroupBy(product => product.Category)
            .Select(group => (group.Key, group.Count()));

    public static int SumNumbers() => Numbers.Sum();

    public static long TotalCharactersInDictionary() => DictionaryReader.ReadWords().Sum(word => (long)word.Length);

    public static int ShortestWordLength() => DictionaryReader.ReadWords().Min(word => word.Length);

    public static int LongestWordLength() => DictionaryReader.ReadWords().Max(word => word.Length);

    public static double AverageWordLength() => DictionaryReader.ReadWords().Average(word => word.Length);
}
