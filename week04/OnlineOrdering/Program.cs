using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("1210 Paint Lane", "Carrollton", "AR", "USA");
        Customer customer1 = new Customer("Ruth Blake", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Book", "1", 20.99, 2));
        order1.AddProduct(new Product("Pens", "2", 1.99, 1));

        DisplayOrder(order1);

        Console.WriteLine("--------------------------------");

        Address address2 = new Address("620 Cannes Place", "Centerton", "TX", "Canada");
        Customer customer2 = new Customer("Malan Blake", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Notebook", "3", 5.50, 3));
        order2.AddProduct(new Product("Pen", "4", 1.25, 4));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
    }
}
