namespace ShopConsole;

public class CartItem
{
    public Product Product { get; }
    public int Quantity { get; set; }

    public decimal Total => Product.Price * Quantity;

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}
