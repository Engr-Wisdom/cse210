using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var address1 = new Address("123 Main St", "Provo", "UT", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B123", 10.0, 2));
        order1.AddProduct(new Product("Pen", "P456", 1.5, 5));

        var address2 = new Address("42 Street", "Lagos", "LA", "Nigeria");
        var customer2 = new Customer("Wisdom Effiong", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "L789", 800.0, 1));
        order2.AddProduct(new Product("Mouse", "M321", 25.0, 1));

        var orders = new List<Order> { order1, order2 };

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"\n--- Order {i + 1} ---");
            Console.WriteLine("Packing Label:\n" + orders[i].GetPackingLabel());
            Console.WriteLine("Shipping Label:\n" + orders[i].GetShippingLabel());
            Console.WriteLine("Total Price: $" + orders[i].GetTotalCost().ToString("F2"));
        }
    }
}
