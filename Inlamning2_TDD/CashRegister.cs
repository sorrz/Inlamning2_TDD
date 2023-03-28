using Inlamning2_TDD.Models;
using Inlamning2_TDD.Repository;
using System.Reflection.Metadata.Ecma335;
using Inlamning2_TDD.Interface;

public class CashRegister
{
    private Order order;
    private Handler handler;
    private Interactions interactions;
    private ProductRepository productRepository;
    private CampaignRepository campaignRepository;
    public string[] userCommandArray;
    private AdminTools adminTools;
    public CashRegister()
    {
        handler = new Handler();
        interactions = new Interactions();
        productRepository = new ProductRepository();
        order = new Order(productRepository);
        userCommandArray = new string[2];
        campaignRepository = new CampaignRepository();
        adminTools = new AdminTools(campaignRepository, productRepository);
    }

    public void NewOrder()
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
            AddOrderItem(userCommandArray, order);
        }
    }

    private void AddOrderItem(string[] userCommandArray, Order order)
    {
        int id;
        int count;
        var c1 = userCommandArray[0].ToString();
        var c2 = userCommandArray[1].ToString();
        int.TryParse(c1, out id);
        int.TryParse(c2, out count);
        order.AddOrderRow(id, count);
        if (order.lines.Count > 0)
        {
            Interactions.PrintOrderRows(order);
        }
    }

    private ErrorMessageEnum ValidateCommand(string userCommand)
    {
        if (userCommand.ToLower() == "pay") 
        {
            order.Pay(order);   // TODO: Fix the PAY FUNCTION! 
            Start();
        }
        userCommandArray = userCommand.Split(' ');
        if (userCommandArray == null) return ErrorMessageEnum.EmptyString;
        if (userCommandArray.Length == 0) return ErrorMessageEnum.WrongCommand;
        if (userCommandArray.Length == 1) return ErrorMessageEnum.InvalidFormat;

        if (int.TryParse(userCommandArray[0], out int idvalue))
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
            if (input == "2") adminTools.AdminMenu();
            if (input == "3") Environment.Exit(0);
        }
    }


}