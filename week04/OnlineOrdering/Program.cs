using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear direcciones y clientes
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);

        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Smith", addr2);

        // Crear órdenes
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Book", "P003", 15, 3));
        order2.AddProduct(new Product("Headphones", "P004", 80, 1));

        // Mostrar resultados
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}
