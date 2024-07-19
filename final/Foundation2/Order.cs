public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
    public void SetProduct(List<Product> products)
    {
        _products = products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach(var product in _products)
        {
            total += product.GetTotalPrice();
        }
        total += _customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing List\n";
        foreach ( var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n"; 
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping To:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}