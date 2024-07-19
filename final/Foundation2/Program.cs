using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("555 Montes de Oca St", "Tijuana", "Baja California", "22014", "Mexico");
        Address address2 = new Address("752 Golder Lantern St", "Carlsbad", "San Diego", "92008", "USA");

        Customer customer1 = new Customer("Pedro Fernandez", address1);
        Customer customer2 = new Customer("Nick Larsen", address2);

        Product product1 = new Product("Television", 57, 1299.99m, 1);
        Product product2 = new Product("Headphones", 75, 39.99m, 3);
        Product product3 = new Product("Mouse", 13, 27.83m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1: ");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotal():C}\n");

        Console.WriteLine("Order 2: ");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotal():C}\n");


    }
}