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
        
        Task AddProduct(string filePath, ProductModel product);
        Task<ProductModel> GetProductByEanId(string filePath, string eanId);
        Task<IEnumerable<ProductModel>> GetProducts(string filePath);
        Task<ProductModel> GetProductById(string filePath, string id);
        Task UpdateProduct(string filePath, ProductModel entity);
    }
}
