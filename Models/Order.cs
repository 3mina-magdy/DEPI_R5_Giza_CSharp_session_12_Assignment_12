namespace session_12.Models;

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }

    public override string ToString() =>
        $"Order ID: {OrderID}, Date: {OrderDate:d}, Total: {Total:C}";
}
