public class Product
{
    public int ID { get; private set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }
    public string? Category { get; private set; }
    public int SupplierID { get; private set; }
    public int Qty { get; private set; }
    public string Brand { get; private set; }
    public decimal Cost { get; private set; }
    public decimal Price { get; private set; }
    public decimal Weight { get; private set; }
    public decimal Volume { get; private set; }
    public DateOnly ExpirationDate { get; private set; }
    public string? BarCode { get; private set; }

    public Product(int id, string name, string description, string category, int supplierId, int qty, string brand, decimal cost, decimal price, decimal weight, decimal volume, DateOnly expirationDate, string? barcode)
    {
        ID = id;
        Name = name;
        Description = description;
        Category = category;
        SupplierID = supplierId;
        Qty = qty;
        Brand = brand;
        Cost = cost;
        Price = price;
        Weight = weight;
        Volume = volume;
        ExpirationDate = expirationDate;

        BarCode = barcode;
    }
}