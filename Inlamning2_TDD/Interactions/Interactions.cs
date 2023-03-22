using System.Data;

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

    internal static string[] OrderPrompt()
    {
        Console.WriteLine("Commmands:");
        Console.WriteLine("<id> <number>");
        Console.WriteLine("PAY");
        Console.Write("Command: ");
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return null;
        return input.Split(' '); ;
    }

    internal static void PrintOrderRows(Order order)
    {
        double sum = 0;
        sum = order.GetTotalPrice();
        foreach (var row in order.lines) Console.WriteLine($"{row.ProductName} {row.Amount} * {row.GetSingleCost(row.ProductId)} = {row.Cost}");
        Console.WriteLine($"Total: {sum}");
    }
}