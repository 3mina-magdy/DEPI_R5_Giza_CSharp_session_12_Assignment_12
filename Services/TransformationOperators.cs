using session_12.Data;
using session_12.Models;

namespace session_12.Services;

public static class TransformationOperators
{
    private static readonly int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
    private static readonly int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
    private static readonly int[] NumbersB = { 1, 3, 5, 7, 8 };

    public static IEnumerable<string> ProductNames() =>
        ListGenerator.ProductsList.Select(product => product.ProductName);

    public static IEnumerable<object> UpperAndLowerCaseWords()
    {
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        return words.Select(word => new { Uppercase = word.ToUpperInvariant(), Lowercase = word.ToLowerInvariant() });
    }

    public static IEnumerable<object> ProductDetailsWithPriceName() =>
        ListGenerator.ProductsList.Select(product => new
        {
            product.ProductID,
            product.ProductName,
            product.Category,
            Price = product.UnitPrice
        });

    public static IEnumerable<(int Number, int Index, bool MatchesPosition)> NumbersComparedWithPosition() =>
        Numbers.Select((number, index) => (number, index, number == index));

    public static IEnumerable<(int NumberA, int NumberB)> PairsWhereAIsLessThanB() =>
        NumbersA.SelectMany(numberA => NumbersB,
            (numberA, numberB) => (numberA, numberB))
            .Where(pair => pair.numberA < pair.numberB)
            .Select(pair => (pair.numberA, pair.numberB));

    public static IEnumerable<(string CustomerName, Order Order)> OrdersWithTotalLessThan500() =>
        ListGenerator.CustomersList
            .SelectMany(customer => customer.Orders,
                (customer, order) => (customer.CustomerName, Order: order))
            .Where(item => item.Order.Total < 500m);

    public static IEnumerable<(string CustomerName, Order Order)> OrdersFrom1998Onward() =>
        ListGenerator.CustomersList
            .SelectMany(customer => customer.Orders,
                (customer, order) => (customer.CustomerName, Order: order))
            .Where(item => item.Order.OrderDate.Year >= 1998);
}
