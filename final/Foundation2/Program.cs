using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Product 1", 1001001, 10.99, 2);
        Product product2 = new Product("Product 2", 1002002, 5.99, 3);
        Product product3 = new Product("Product 3", 1003003, 7.49, 1);

        // Create some customers
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Address address2 = new Address("456 Broad St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Order 1:");
        Console.WriteLine("\nPacking Label");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal price: {order1.GetTotalPrice():C2}");

        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Order 2:");
        Console.WriteLine("\nPacking Label");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal price: {order2.GetTotalPrice():C2}");
    }
}