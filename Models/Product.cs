namespace session_12.Models;

public class Product : IComparable<Product>
{
    public long ProductID { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public int CompareTo(Product? other) => UnitPrice.CompareTo(other?.UnitPrice);

    public override string ToString() =>
        $"ID: {ProductID}, Name: {ProductName}, Category: {Category}, Price: {UnitPrice:C}, Stock: {UnitsInStock}";
}
