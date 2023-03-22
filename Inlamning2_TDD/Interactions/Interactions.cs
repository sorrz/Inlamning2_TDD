using System.Data;

internal class Interactions
{
    internal static void Menu(Order order)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"1. Ny Kund\n" +
                $"2. Admin Verktyg\n" +
                $"3. Avsluta  ");
            var input = Console.ReadLine();
            if (input == "1") CashRegister.NewOrder(ref order);
            if (input == "2") AdminTools.Menu();  //TODO: Fix the Admin Menu
            if (input == "3") Environment.Exit(0);

        }
    }

    internal static string[] OrderPrompt()
    {
        Console.WriteLine("Esc to Escpae");
        Console.WriteLine("Commmands:");
        Console.WriteLine("<id> <number>");
        Console.WriteLine("PAY");
        Console.Write("Command: ");
        var input = Console.ReadLine().Split(' ');
        return input;
    }
}