using session_12.Data;
using session_12.Models;

namespace session_12.Services;

public static class ElementOperators
{
    public static Product? FirstProductOutOfStock() =>
        ListGenerator.ProductsList.FirstOrDefault(product => product.UnitsInStock == 0);

    public static Product? FirstProductPriceGreaterThan1000() =>
        ListGenerator.ProductsList.FirstOrDefault(product => product.UnitPrice > 1000m);

    public static int? SecondNumberGreaterThan5()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        return numbers.Where(number => number > 5).Select(number => (int?)number).ElementAtOrDefault(1);
    }
}
