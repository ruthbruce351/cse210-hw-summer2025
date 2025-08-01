using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("STREET", "CITY", "STATE", "COUNTRY");
        Customer customer1 = new Customer("Ruth Blake", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Test1", 20.99, 2));
        order1.AddProduct(new Product("Test2", 1.99, 1));

        DisplayOrder(order1);

        static void DisplayOrder(Order order)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
        }
    }
}