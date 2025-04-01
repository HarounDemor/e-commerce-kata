namespace Carts;

public class Cart
{
    public List<CartItem> Items;

    public Cart()
    {
        Items = new List<CartItem>();
    }

    public void AddItem(string name, int quantity, int price, bool isGameConsole)
    {
        Items.Add(new CartItem(name, quantity, price, isGameConsole));
    }

    public decimal GetPrice(Promos[] promos)
    {
        if (promos.Contains(Promos.Promo3)
            && Items.Single(i => i.Name == "Premium Cap").Quantity >= 2
            && Items.Single(i => i.Name == "Classic T-Shirt").Quantity > 1)
        {
            Items.Single(i => i.Name == "Classic T-Shirt").SetGiftedQuantity(1);
        }

        var price = Items
            .Select(i => i.GetTotalPrice(applyPromo1: promos.Contains(Promos.Promo1), applyPromo4: promos.Contains(Promos.Promo4)))
            .Sum();

        if (promos.Contains(Promos.Promo2))
        {
            price = price - (price / 200) * 10;
        }

        return price;
    }
}

public class CartItem
{
    public string Name;

    public int Price;

    public int Quantity;

    private int _giftedQuantity;

    private bool _isGameConsole;

    public CartItem(string name, int quantity, int price, bool isGameConsole)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        _isGameConsole = isGameConsole;
    }

    public void SetGiftedQuantity(int giftedQuantity)
    {
        _giftedQuantity = giftedQuantity;
    }

    public decimal GetTotalPrice(bool applyPromo1 = false, bool applyPromo4 = false)
    {
        var quantity = Quantity - _giftedQuantity;

        if (applyPromo1)
        {
            return Price * ((quantity / 2) + (quantity % 2));
        }

        if (applyPromo4 && _isGameConsole)
        {
            return Price * quantity * 0.9M;
        }

        return Price * quantity;
    }
}

public enum Promos
{
    Promo1, Promo2, Promo3, Promo4
}