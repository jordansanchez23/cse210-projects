public class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

     public int GetId()
    {
        return _id;
    }

    public void SetId(int Id)
    {
        _id = Id;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    } 

    public void Setquantity(int quantity)
    {
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }
}