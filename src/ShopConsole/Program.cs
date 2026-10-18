using ShopConsole;

const string shopName = "MyShop";
const decimal vatRate = 0.15m;

List<Product> products =
[
    new Product(1, "Notebook", 45.50m, 20),
    new Product(2, "Pen", 10.00m, 100),
    new Product(3, "Water Bottle", 120.00m, 15),
    new Product(4, "Backpack", 950.00m, 5),
    new Product(5, "Calculator", 650.00m, 8)
];

List<CartItem> cart = [];

Console.WriteLine($"===== Welcome to {shopName} =====");

bool running = true;

while (running)
{
    ShowMenu();
    int choice = ReadInt("Choose an option: ");
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            ShowProducts();
            break;
        case 2:
            AddToCart();
            break;
        case 3:
            ShowCart();
            break;
        case 4:
            Checkout();
            break;
        case 0:
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    Console.WriteLine();
}

Console.WriteLine($"Thank you for visiting {shopName}. Goodbye!");

void ShowMenu()
{
    Console.WriteLine("1. View products");
    Console.WriteLine("2. Add product to cart");
    Console.WriteLine("3. View cart");
    Console.WriteLine("4. Checkout");
    Console.WriteLine("0. Exit");
}

void ShowProducts()
{
    Console.WriteLine($"{"ID",-4}{"Name",-15}{"Price",10}{"Stock",8}");
    Console.WriteLine(new string('-', 37));

    foreach (Product product in products)
    {
        Console.WriteLine($"{product.Id,-4}{product.Name,-15}{product.Price,10:N2}{product.Stock,8}");
    }
}

void AddToCart()
{
    ShowProducts();
    Console.WriteLine();

    int id = ReadInt("Enter product ID: ");
    Product? product = FindProduct(id);

    if (product == null)
    {
        Console.WriteLine("Product not found.");
        return;
    }

    if (product.Stock == 0)
    {
        Console.WriteLine($"{product.Name} is out of stock.");
        return;
    }

    int quantity = ReadInt("Enter quantity: ");

    if (quantity <= 0)
    {
        Console.WriteLine("Quantity must be greater than zero.");
        return;
    }

    if (quantity > product.Stock)
    {
        Console.WriteLine($"Only {product.Stock} {product.Name}(s) available.");
        return;
    }

    CartItem? existingItem = FindCartItem(id);

    if (existingItem == null)
    {
        cart.Add(new CartItem(product, quantity));
    }
    else
    {
        existingItem.Quantity += quantity;
    }

    product.Stock -= quantity;
    Console.WriteLine($"Added {quantity} x {product.Name} to your cart.");
}

void ShowCart()
{
    if (cart.Count == 0)
    {
        Console.WriteLine("Your cart is empty.");
        return;
    }

    Console.WriteLine($"{"Name",-15}{"Qty",5}{"Price",10}{"Total",12}");
    Console.WriteLine(new string('-', 42));

    foreach (CartItem item in cart)
    {
        Console.WriteLine($"{item.Product.Name,-15}{item.Quantity,5}{item.Product.Price,10:N2}{item.Total,12:N2}");
    }

    Console.WriteLine(new string('-', 42));
    Console.WriteLine($"{"Subtotal",-30}{CalculateSubtotal(),12:N2}");
}

void Checkout()
{
    if (cart.Count == 0)
    {
        Console.WriteLine("Your cart is empty. Add some products first.");
        return;
    }

    decimal subtotal = CalculateSubtotal();
    decimal vat = Math.Round(subtotal * vatRate, 2);
    decimal grandTotal = subtotal + vat;

    Console.WriteLine($"========== {shopName} Invoice ==========");
    Console.WriteLine($"Date: {DateTime.Now:dd MMM yyyy, hh:mm tt}");
    Console.WriteLine();
    ShowCart();
    Console.WriteLine($"{"VAT (15%)",-30}{vat,12:N2}");
    Console.WriteLine($"{"Grand Total",-30}{grandTotal,12:N2}");
    Console.WriteLine();
    Console.WriteLine("Payment successful. Thank you for shopping!");

    cart.Clear();
}

decimal CalculateSubtotal()
{
    decimal subtotal = 0;

    foreach (CartItem item in cart)
    {
        subtotal += item.Total;
    }

    return subtotal;
}

Product? FindProduct(int id)
{
    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            return product;
        }
    }

    return null;
}

CartItem? FindCartItem(int productId)
{
    foreach (CartItem item in cart)
    {
        if (item.Product.Id == productId)
        {
            return item;
        }
    }

    return null;
}

int ReadInt(string message)
{
    while (true)
    {
        Console.Write(message);
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            return number;
        }

        Console.WriteLine("Please enter a valid number.");
    }
}
