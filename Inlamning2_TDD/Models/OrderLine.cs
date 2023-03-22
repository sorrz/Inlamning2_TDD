using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;
using Inlamning2_TDD.Repository;

public class OrderLine
{
    private IProductRepository productRepository;

    public int ProductId { get; private set; }
    public double Cost { get; internal set; }

    public OrderLine(int id, int amount)
    {
        productRepository = new productRepository();
        ProductId = GetProducId(id);
        Cost = GetCostofLine(id, amount);
    }

    private int GetProducId(int id)
    {
        var newId = productRepository.GetProductById(id).Id; // TODO Fixa Objekt Instace Fel
        return newId;
    }

    public double GetCostofLine(int id, int amount) 
    {
        var singlePrice = productRepository.GetProductById(id).BasePrice;
        var cost = singlePrice * amount;
        return cost;
    }

}