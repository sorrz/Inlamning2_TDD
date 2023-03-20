using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Interface
{
    public interface IProductRepository
    {
        
        Task AddProduct(ProductModel product);
        List<ProductModel> GetProducts();
        ProductModel GetProductById(int id);
        Task UpdateProduct(ProductModel product);

    }
}
