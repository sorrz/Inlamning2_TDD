using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Repository
{

    public class ProductRepository : IProductRepository
    {
        private readonly string filePath = "hejsan.txt";
        private List<ProductModel> _products;
        public ProductRepository()
        {
            _products = GetProducts();
        }

        public Task AddProduct(ProductModel product)
        {
            if (!DoesProductexist(product)) _products.Add(product);
            else
            {
                GetProductById(product.Id).IncreaseCount(product.Count);
            }

            SaveProductList();
            return Task.CompletedTask;
        }

        private void SaveProductList()
        {
            var result = new List<string>();
            foreach (ProductModel prod in _products) result.Add(SerializeProduct(prod));
            File.WriteAllLines(filePath, result.ToArray());
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
            var _list = File.ReadAllLines(filePath).ToList();
            var products = DeserializeProductList(_list);
            return products;
        }

        public Task UpdateProduct(ProductModel product)
        {
            if (!DoesProductexist(product)) _products.Add(product);
            else
            {
                GetProductById(product.Id)
                    .UpdateProductInfo(product.Name, product.Count, product.BasePrice);
            }
            SaveProductList();
            return Task.CompletedTask;
        }

        public string SerializeProduct(ProductModel product)
        {
            return $"{product.Id},{product.Name},{product.Count},{product.BasePrice},{product.PriceType}";
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
                    Convert.ToDouble(i[3]),
                    Convert.ToInt32(i[4])
                    );
                products.Add(x);
            }
            return products;
        }

        private bool DoesProductexist(ProductModel product)
        {
            return _products.Exists(p => p.Id == product.Id);
        }



    }
}
