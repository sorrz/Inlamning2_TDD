using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Interface
{
    public interface IProductRepository
    {
        
        Task AddProduct(ProductModel product);
        List<ProductModel> GetProducts();
        void CreateProduct(int id, string? name, int count, double basePrice, int priceType);
        ProductModel GetProductById(int id);
        Task UpdateProduct(ProductModel product);

    }
}
