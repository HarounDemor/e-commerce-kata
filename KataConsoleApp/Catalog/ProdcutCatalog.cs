namespace Catalog;

public class ProductCatalog
{
    private Dictionary<string, Product> products;

    public ProductCatalog()
    {
        products = new Dictionary<string, Product>();
        products.Add("Classic T-Shirt", new Product("Classic T-Shirt", 30, 150, isGameConsole: true));
        products.Add("Longsleeve T-Shirt", new Product("Longsleeve T-Shirt", 50, 100, isGameConsole: true));
        products.Add("Classic Cap", new Product("Classic Cap", 10, 200));
        products.Add("Premium Cap", new Product("Premium Cap", 20, 50));
    }

    public ProductDto? GetProduct(string name, int quantity)
    {
        if (!products.TryGetValue(name, out var product)) return null;

        if (quantity > product.Quantity) return null;

        return new ProductDto(product.Id, product.Name, product.Price, product.IsGameConsole);
    }
}

public record ProductDto(string Id, string Name, int Price, bool IsGameConsole);
