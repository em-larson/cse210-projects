using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Galaxy Dice", 1005, 13.99, 1);
        Product p2 = new Product("Fire Dice", 1007, 13.99, 1);
        Product p3 = new Product("Dark Dice Tray", 1012, 25.00, 3);
        Product p4 = new Product("Custom Dice", 1001, 20.00, 1);
        Product p5 = new Product("Dice Dragon", 1023, 9.98, 2);
        Product p6 = new Product("Dice Jail", 1031, 17.89, 1);
        Product p7 = new Product("Class Stickers", 1042, 4.99, 3);

        Address a1 = new Address("1234 S. 5678 W", "Ogden", "UT", "US");
        Customer c1 = new Customer("Matt Mercer", a1);
        Order o1 = new Order(c1, [p1, p2, p3, p4]);

        Address a2 = new Address("1212 N.", "Ontario", "Toronto", "Canada");
        Customer c2 = new Customer("Laura Bailey", a2);
        Order o2 = new Order(c2, [p7, p6, p5, p2]);

        List<Order> orders = new List<Order> { o1, o2 };

        foreach (Order o in orders)
        {
            o.PackingLabel();
            Console.WriteLine("");
            o.ShippingLabel();
            Console.WriteLine("");
            Console.WriteLine($"Total Cost: {o.TotalCost()}");
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}