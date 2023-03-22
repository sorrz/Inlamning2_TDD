using Inlamning2_TDD.Models;
using Inlamning2_TDD.Repository;
using System.Reflection.Metadata.Ecma335;

public class CashRegister
{
    private Order order;
    private Handler handler;
    private Interactions interactions;
    private ProductRepository productRepository;
    public CashRegister()
    {
        handler = new Handler();
        interactions = new Interactions();
        productRepository = new ProductRepository();
        order = new Order(productRepository);

    }

    internal void NewOrder()
    {
        while (true)
        {
            var userCommand = Interactions.OrderPrompt();
            var validatedCommand = ValidateCommand(userCommand);
            if (validatedCommand != ErrorMessageEnum.Ok)
            {
                Handler.ErrorPrinter(validatedCommand);
                continue;
            }
            AddOrderItem(userCommand, order);
        }
    }

    private void AddOrderItem(string[] userCommand, Order order)
    {
        int id;
        int count;
        var c1 = userCommand[0].ToString();
        var c2 = userCommand[1].ToString();
        int.TryParse(c1, out id);
        int.TryParse(c2, out count);
        order.AddOrderRow(id, count);
        if (order.lines.Count > 0)
        {
            Interactions.PrintOrderRows(order);
        }
    }

    private ErrorMessageEnum ValidateCommand(string[] userCommand)
    {
        if (userCommand == null) return ErrorMessageEnum.EmptyString;
        if (userCommand.Length == 0) return ErrorMessageEnum.WrongCommand;
        if (userCommand.Length == 1) return ErrorMessageEnum.InvalidFormat;

        if (int.TryParse(userCommand[0], out int idvalue))
        {
            productRepository.GetProductById(idvalue);
        }
        return ErrorMessageEnum.Ok;
    }

    public void Start()
    {
        while (true)
        {
            var input = interactions.MenuPrinter();
            if (input == "1") NewOrder();
            if (input == "2") AdminTools.Menu();  //TODO Fix the Admin Menu
            if (input == "3") Environment.Exit(0);
        }
    }


}