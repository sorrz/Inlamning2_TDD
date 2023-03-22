using Inlamning2_TDD.Repository;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private readonly string IdFilePath = "RId.txt";
    private readonly string ReceiptFile = "";

    private ProductRepository productRepository;

    public DateOnly ReceiptDate { get; private set; }
    public int OrderId { get; private set; }
    public List<OrderLine> lines;
    public double sum { get; private set; }
    public Order(ProductRepository productRepository)
    {
        lines = new List<OrderLine>();
        OrderId = SetNewId();
        ReceiptDate = DateOnly.FromDateTime(DateTime.Now);
        this.productRepository = productRepository;
        ReceiptFile = $"Receipts_{ReceiptDate}";
    }

    private int SetNewId()
    {
        var newID = 0;
        if (File.Exists(IdFilePath))
        {
            var lastID = Convert.ToInt32(File.ReadAllText(IdFilePath));
            newID = lastID++;
            File.WriteAllText(IdFilePath, newID.ToString());
            return newID;
        }
        else
        {
            newID = 1;
            File.WriteAllText(IdFilePath, newID.ToString());
            return newID;
        }
    }


    internal void AddOrderRow(int id, int item2)
    {
        if (lines.Exists(x => x.ProductId == id))
        {
            var line = lines.First(x => x.ProductId == id);
            line.AddProductAmoutn(item2);
        }
        else
            lines.Add(new OrderLine(id, item2, productRepository));
    }


    public double GetTotalPrice()
    {
        sum = 0;
        foreach (OrderLine line in lines) sum += line.Cost;
        return sum;
    }


}