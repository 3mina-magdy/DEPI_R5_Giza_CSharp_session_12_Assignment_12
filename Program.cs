using session_12.Services;

namespace session_12;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("========== LINQ ASSIGNMENT 01 ==========");

        Section("Restriction Operators");
        Print("1. Products out of stock", RestrictionOperators.ProductsOutOfStock());
        Print("2. In-stock products costing more than 3", RestrictionOperators.InStockAndPriceGreaterThan3());
        Print("3. Digit names shorter than their value", RestrictionOperators.DigitNamesShorterThanTheirValue());

        Section("Element Operators");
        PrintValue("1. First product out of stock", ElementOperators.FirstProductOutOfStock());
        PrintValue("2. First product over 1000 (null if none)", ElementOperators.FirstProductPriceGreaterThan1000());
        PrintValue("3. Second number greater than 5", ElementOperators.SecondNumberGreaterThan5());

        Section("Aggregate Operators");
        PrintValue("1. Number of odd numbers", AggregateOperators.CountOddNumbers());
        Print("2. Order count per customer", AggregateOperators.OrderCountPerCustomer());
        Print("3. Product count per category", AggregateOperators.ProductCountPerCategory());
        PrintValue("4. Sum of numbers", AggregateOperators.SumNumbers());
        PrintValue("5. Total characters in dictionary", AggregateOperators.TotalCharactersInDictionary());
        PrintValue("6. Shortest word length", AggregateOperators.ShortestWordLength());
        PrintValue("7. Longest word length", AggregateOperators.LongestWordLength());
        PrintValue("8. Average word length", AggregateOperators.AverageWordLength());

        Section("Ordering Operators");
        Print("1. Products by name", OrderingOperators.ProductsByName());
        Print("2. Case-insensitive word sort", OrderingOperators.CaseInsensitiveWords());
        Print("3. Products by stock descending", OrderingOperators.ProductsByStockDescending());
        Print("4. Digits by name length then alphabetically", OrderingOperators.DigitsByNameLengthThenAlphabetically());
        Print("5. Words by length then case-insensitive", OrderingOperators.WordsByLengthThenCaseInsensitive());
        Print("6. Products by category then price descending", OrderingOperators.ProductsByCategoryThenPriceDescending());
        Print("7. Words by length then case-insensitive descending", OrderingOperators.WordsByLengthThenCaseInsensitiveDescending());
        Print("8. Digits with second letter 'i', reversed", OrderingOperators.DigitsWithSecondLetterIReversed());

        Section("Transformation Operators");
        Print("1. Product names", TransformationOperators.ProductNames());
        Print("2. Uppercase and lowercase word versions", TransformationOperators.UpperAndLowerCaseWords());
        Print("3. Product properties with UnitPrice renamed Price", TransformationOperators.ProductDetailsWithPriceName());
        Print("4. Numbers compared with their indexes", TransformationOperators.NumbersComparedWithPosition());
        Print("5. Pairs where numberA < numberB", TransformationOperators.PairsWhereAIsLessThanB());
        Print("6. Orders with total less than 500", TransformationOperators.OrdersWithTotalLessThan500());
        Print("7. Orders from 1998 onward", TransformationOperators.OrdersFrom1998Onward());
    }

    private static void Section(string title)
    {
        Console.WriteLine();
        Console.WriteLine($"\n--- {title} ---");
    }

    private static void Print<T>(string title, IEnumerable<T> values)
    {
        Console.WriteLine($"\n{title}:");
        foreach (T value in values) Console.WriteLine(value);
    }

    private static void PrintValue<T>(string title, T? value)
    {
        Console.WriteLine($"\n{title}:");
        Console.WriteLine(value is null ? "No match (null)." : value);
    }
}
