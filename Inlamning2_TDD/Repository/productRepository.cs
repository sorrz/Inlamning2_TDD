using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2_TDD.Repository
{
    
    public class productRepository : IProductRepository
    {
        private readonly string filePath = "hejsan.txt";
        private List<ProductModel> _products;
        public productRepository()
        {
            _products = GetProducts();
        }


        public Task AddProduct(ProductModel product)
        {
            _products.Add(product);
            
            File.WriteAllLines(filePath, _products);
            return Task.CompletedTask;
        }

        public ProductModel GetProductById(int id)
        {
            foreach (ProductModel prod in _products)
            {
                if (prod.Id == id) return prod;
            }

            return null;
        }

        public List<ProductModel> GetProducts()
        {


            // Build a IF check for the ID,
            // if Id matches then + the count, ignore the other parameters.


            var _list = File.ReadAllLines(filePath).ToList();
            var products = DeserializeProductList(_list);
           
            
            return products;
        }

        public Task UpdateProduct(ProductModel product)
        {

            // Find the ID
            // Replace the parameter that is notEqual with the new value
            // Save the List and Write to File

            throw new NotImplementedException();
        }

        public void SerializeProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> DeserializeProductList(List<string> _list)
        {
            var products = new List<ProductModel>();
            foreach (var line in _list)
            {
                string[] i = line.Split(',');
                ProductModel x = new ProductModel(
                    Convert.ToInt32(i[0]),
                    i[1],
                    Convert.ToInt32(i[2]),
                    Convert.ToDouble(i[3])
                    ); ;
                products.Add(x);
            }
            return products;
        }



    }
}
