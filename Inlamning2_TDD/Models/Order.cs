using System.Security.Cryptography.X509Certificates;

internal class Order
{
    private readonly string idFilePath = "RId.txt";
    public int OrderId { get; private set; }
    public List<OrderLine> lines;
    public double sum = 0;
    public Order()
    {
        lines = new List<OrderLine>();
        OrderId = SetNewId();
    }


    private int SetNewId()
    {
        var newID = 0;
        if (File.Exists(idFilePath)) 
        {
            var lastID = Convert.ToInt32(File.ReadAllText(idFilePath));
            newID = lastID++;
            File.WriteAllText(idFilePath, newID.ToString());
            return newID;
        } 
        else
        {
            newID = 1;
            File.WriteAllText(idFilePath, newID.ToString() ); 
            return newID;
        }
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