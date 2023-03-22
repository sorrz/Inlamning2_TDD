using Inlamning2_TDD.Models;
using System.Diagnostics.CodeAnalysis;

public class CashRegister
{
    private Order order;
    private Handler handler;
    private Interactions interactions;
    public CashRegister()
    {
        handler = new Handler();
        order = new Order();
        interactions= new Interactions();
    }

    internal static void NewOrder(Order order)
    {
        while (true)
        {
            
            
            var userCommand = Interactions.OrderPrompt();
            var validatedCommand = ValidateCommand(userCommand);
            if (validatedCommand.Item1 == 0) Handler.ErrorPrinter(ErrorMessageEnum.WrongCommand);
            if (validatedCommand.Item2 == 0) Handler.ErrorPrinter(ErrorMessageEnum.InvalidFormat);
            order.AddOrderRow(validatedCommand.Item1, validatedCommand.Item2);
            var listItemCount = validatedCommand.Item2;
            var listItemId = validatedCommand.Item1;
            order.UpdateSum(listItemId, listItemCount);
            if (order.lines.Count > 0)
            {
                Interactions.PrintOrderRows(order, listItemCount);
            }

        }
    }

    private static Tuple<int, int> ValidateCommand(string[] userCommand)
    {
        // TODO Blir detta rätt? 
        if (userCommand.ToString == string.IsNullOrEmpty) return Tuple.Create(0, 0);
        if (userCommand.Length == 0) return Tuple.Create(0, 0);
        if (userCommand.Length == 1) return Tuple.Create(1, 0);
        
        int id;
        int count;
        var c1 = userCommand[0].ToString();
        var c2 = userCommand[1].ToString();
        int.TryParse(c1, out id);
        int.TryParse(c2, out count);

        return Tuple.Create(id, count);
    }

    // Catch Method to Navigate User to the Main Menu
    public void Start()
    {
        Interactions.Menu(order);
    }


}