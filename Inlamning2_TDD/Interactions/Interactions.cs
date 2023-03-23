using System.Data;
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
        Console.WriteLine($"KVITO {order.OrderId}  {order.ReceiptDate}"); 
        double sum = 0;
        sum = order.GetTotalPrice();
        foreach (var row in order.lines) Console.WriteLine($"{row.ProductName} {row.Amount} * {row.GetSingleCost(row.ProductId)} = {row.Cost}");
        Console.WriteLine($"Total: {sum}");
    }

    public static List<string> GetCampaignInput()
    {
        List<string> _list = new();
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
}