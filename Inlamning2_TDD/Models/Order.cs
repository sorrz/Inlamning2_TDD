using System.Security.Cryptography.X509Certificates;

internal class Order
{
    public List<OrderLine> lines;
    public double sum = 0;
    public Order()
    {
        lines = new List<OrderLine>();
    }

    public double GetTotalPrice()
    {
        foreach (OrderLine line in lines) sum += line.Cost;
        return sum;
    }

}