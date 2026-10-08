using session_12.Data;
using session_12.Models;

namespace session_12.Services;

public static class RestrictionOperators
{
    public static IEnumerable<Product> ProductsOutOfStock() =>
        ListGenerator.ProductsList.Where(product => product.UnitsInStock == 0);

    public static IEnumerable<Product> InStockAndPriceGreaterThan3() =>
        ListGenerator.ProductsList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3.00m);

    public static IEnumerable<string> DigitNamesShorterThanTheirValue()
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return digits.Where((name, value) => name.Length < value);
    }
}
