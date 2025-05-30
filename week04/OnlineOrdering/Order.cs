public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double TotalCost()
    {
        double totalcost = 0;
        foreach (Product p in _products)
        {
            double cost = p.Cost();
            totalcost = totalcost + cost;
        }

        bool location = _customer.InUS();
        if (location == true)
        {
            totalcost = totalcost + 5;
        }

        else
        {
            totalcost = totalcost + 35;
        }

        return totalcost;
    }

    public void PackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine(p.DisplayProduct());
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
}