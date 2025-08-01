public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += customer.IsUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += customer.GetName() + "\n";
        label += customer.GetAddressString();
        return label;
    }
}