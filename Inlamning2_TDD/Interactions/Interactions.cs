using System.Data;
using System.Runtime.InteropServices;
using Inlamning2_TDD.Models;

internal class Interactions
{
    internal string MenuPrinter()
    {
            Console.Clear();
            Console.WriteLine($"1. Ny Kund\n" +
                $"2. Admin Verktyg\n" +
                $"3. Avsluta  ");
            return Console.ReadLine();
    }

    internal static string OrderPrompt()
    {
        Console.WriteLine("Commmands:");
        Console.WriteLine("<id> <number>");
        Console.WriteLine("PAY");
        Console.Write("Command: ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return null;
        return input;
    }

    internal static void PrintOrderRows(Order order)
    {
        Console.WriteLine($"KVITTO {order.OrderId}  {order.ReceiptDate}"); 
        double sum = 0;
        sum = order.GetTotalPrice();
        foreach (var row in order.lines) Console.WriteLine($"{row.ProductName} {row.Amount} * {row.GetSingleCost(row.ProductId)} = {row.Cost}");
        Console.WriteLine($"Total: {sum}");
    }

    public static List<string> GetCampaignInput()
    {
        List<string> _list = new();
        Console.Write("Please Enter the a New Campaign ID: ");
        _list.Add(Console.ReadLine());
        Console.Write("Please Enter the ProductId to which we wanna apply the Campaign: ");
        _list.Add(Console.ReadLine());
        Console.WriteLine("Please Enter a From Date (YYYY-MM-DD");
        _list.Add(Console.ReadLine());
        Console.WriteLine("Please Enter a To Date (YYYY-MM-DD");
        _list.Add(Console.ReadLine());
        Console.WriteLine("Please Enter a new Price");
        _list.Add(Console.ReadLine());
        return _list;
    }

    public static ProductModel GetProductInput()
    {
        Console.Write("Mata in ID: ");
        var id = Convert.ToInt32(Console.ReadLine());
        Console.Write("mata in Namn: ");
        var name = Console.ReadLine();
        Console.Write("Mata in Lagermängd: ");
        var count = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mata in BasPris för produkten: ");
        var basePrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Pris per KG (0) eller Pris per St (1)");
        var priceType = Convert.ToInt32(Console.ReadLine());
        var x = new ProductModel(id, name, count, basePrice, priceType);
        return x;
    }

    public static int GetProductID()
    {
        Console.Write("Vilket Produkt ID vill du uppdatera? ");
        var id = Convert.ToInt32(Console.ReadLine());
        return id;
    }

    public static List<string> GetUpdateParams()
    {
        List<string> _input = new();
        Console.Write("Mata in Nytt Namn: ");
        var newName = Console.ReadLine();
        Console.Write("Mata in Ny Count: ");
        var newCount = Console.ReadLine();
        Console.Write("Mata in Nytt Bas Pris: ");
        var newPrice = Console.ReadLine();
        _input.Add(newName);
        _input.Add(newCount);
        _input.Add(newPrice);
        return _input;

    }

    public static int GetCampaignID()
    {
        Console.Write("Vilket Kampanj ID vill du Redigera? ");
        var campID = Convert.ToInt32(Console.ReadLine());
        return campID;
    }
}