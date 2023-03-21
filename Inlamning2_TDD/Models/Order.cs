using System.Security.Cryptography.X509Certificates;

internal class Order
{
    private Receipt receipt;
    private Guid OrderId { get; set; }
    public List<OrderLine> lines;
    public double sum = 0;
    public Order()
    {
        OrderId = new Guid();
        lines = new List<OrderLine>();
    }


    


    internal void AddOrderRow(int item1, int item2)
    {
        lines.Add(new OrderLine(item1, item2));
    }


    public double GetTotalPrice()
    {
        foreach (OrderLine line in lines) sum += line.Cost;
        return sum;
    }

}