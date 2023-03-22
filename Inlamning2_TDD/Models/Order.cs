internal class Order
{
    private readonly string idFilePath = "RId.txt";
    private readonly string ReceiptFile = $"Receipts_{ReceiptDate}"; // TODO: Fixa! 
    public DateOnly ReceiptDate { get; private set; }
    public int OrderId { get; private set; }
    public List<OrderLine> lines;
    public double sum { get; private set; }
    public Order()
    {
        lines = new List<OrderLine>();
        OrderId = SetNewId();
        ReceiptDate = DateOnly.FromDateTime(DateTime.Now);
    }

    // TODO: Logikfel, HJÄLP! 
    public double UpdateSum(int id, int count)
    {
        sum = 0;
        foreach (var line in lines)
        {
            sum += line.GetCostofLine(id, count);
        }
        return sum;
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
            File.WriteAllText(idFilePath, newID.ToString());
            return newID;
        }
    }


    internal void AddOrderRow(int id, int item2)
    {
        lines.Add(new OrderLine(id, item2));
    }


    public double GetTotalPrice()
    {
        foreach (OrderLine line in lines) sum += line.Cost;
        return sum;
    }

}