using System;

class Program
{
    static void Main(string[] args)
    {
        Adress adress1 = new Adress("123 Main Street", "Aspen", "Colorado", "USA");
        Custumer customer1 = new Custumer("Jonh Denver", adress1);

        Product product1 = new Product("Iphone 15 Pro Max", 155, 1199, 3);
        Product product2 = new Product("Dell Latitude 3500", 250, 2000, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.ComputeTotalPrice()}");

        Adress adress2 = new Adress("ALFREDO V 5249, FERROCARRILERA, 64250", "Nuevo Leon", "Monterrey", "Mexico");
        Custumer customer2 = new Custumer("Carlos Martinéz", adress2);

        Product product3 = new Product("Laptop Lenovo", 242, 2200, 1);
        Product product4 = new Product("Tablet Samsung", 88, 1500, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.ComputeTotalPrice()}");

    }
}