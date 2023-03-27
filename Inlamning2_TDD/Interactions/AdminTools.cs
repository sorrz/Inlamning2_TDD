internal class AdminTools
{
    internal static void AdminMenu()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine($"1. Lägg till Produkt\n" +
                              $"2. Ändra på Produkt\n" +
                              $"3. Lägg till Kampanj\n" +
                              $"4. Ändra på Kampanj\n" +
                              $"5. Gå tillbaka...");
            // return Console.ReadKey();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:

                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    return;
            }
        }
    }
}