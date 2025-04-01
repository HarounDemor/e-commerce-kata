public class Product
{
    public string Id;

    public string Name;

    public int Price;

    public int Quantity;

    public bool IsGameConsole;

    public Product(string name, int price, int quantity, bool isGameConsole = false)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Price = price;
        Quantity = quantity;
        IsGameConsole = isGameConsole;
    }
}