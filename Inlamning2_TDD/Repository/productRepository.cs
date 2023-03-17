using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2_TDD.Repository
{
    
    public class productRepository : IProductRepository
    {
        public productRepository()
        {

        }
        public Task AddProduct(string filePath, ProductModel product)
        {
            return Task.CompletedTask;
        }

        public Task<ProductModel> GetProductByEanId(string filePath, string eanId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetProductById(string filePath, string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> GetProducts(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(string filePath, ProductModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
