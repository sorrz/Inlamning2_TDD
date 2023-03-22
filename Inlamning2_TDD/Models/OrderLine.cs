using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;
using Inlamning2_TDD.Repository;

public class OrderLine
{
    private IProductRepository productRepository;

    public int ProductId { get; private set; }
    public double Cost { get; internal set; }
    public string ProductName { get; private set; }

    public double PricePer { get ; private set; }
    public int Amount { get ; private set; }

    public OrderLine(int id, int amount, ProductRepository productRepository)
    {
        this.productRepository = productRepository;
        ProductId = GetProducId(id);
        Cost = GetCostofLine(id, amount);
        PricePer = GetSingleCost(id);
        ProductName = GetProductName(id);
        Amount = amount;
        
    }


    public void AddProductAmoutn(int amount)
    {
        Amount += amount;
    }

    private string? GetProductName(int id)
    {
        return productRepository.GetProductById(id).Name;
    }

    private int GetProducId(int id)
    {
        var newId = productRepository.GetProductById(id).Id; // TODO Fixa Objekt Instace Fel
        return newId;
    }

    public double GetSingleCost(int id)
    {
        return productRepository.GetProductById(id).BasePrice;

    }

    public double GetCostofLine(int id, int amount) 
    {
        var singlePrice = productRepository.GetProductById(id).BasePrice;
        var cost = singlePrice * amount;
        return cost;
    }

}