using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("23591 Pumula St", "Bulawayo", "ID", "USA");
        Address internationalAddress = new Address("9418 Mavondo Rd", "Bulawayo", "Bulawayo", "Zimbabwe");

        Customer usaCustomer = new Customer("Nigel Ndlovu", usaAddress);
        Customer internationalCustomer = new Customer("Ridah Ndlovu", internationalAddress);

        Product product1 = new Product("Book", "BK001", 10, 5);
        Product product2 = new Product("Pen", "PN034", 2, 10);
        Product product3 = new Product("Paper", "PR152", 25, 3);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice():C}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice():C}\n");
    }
}