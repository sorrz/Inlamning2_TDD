using Inlamning2_TDD.Models;

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

    internal static void NewOrder(ref Order order)
    {
        while (true)
        {
            var userCommand = Interactions.OrderPrompt();
            var validatedCommand = ValidateCommand(userCommand);
            if (validatedCommand.Item2 == 0 ) Handler.ErrorPrinter(Inlamning2_TDD.Models.ErrorMessageEnum.WrongCommand);
            if (validatedCommand.Item2 == 1) Handler.ErrorPrinter(ErrorMessageEnum.InvalidFormat);
            if (validatedCommand.Item2 == 2) order.AddOrderRow(validatedCommand.Item1, validatedCommand.Item2);
        }
    }

    private static Tuple<int, int> ValidateCommand(string[] userCommand)
    {
        // Hur gör vi detta? OSCAR 
        if (userCommand.Length == 0) return Tuple.Create(0, 0);
        if (userCommand.Length == 1) return Tuple.Create(0, 1);
        
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