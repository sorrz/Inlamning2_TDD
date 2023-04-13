using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string filePath = "hejsan.txt";
        private List<ProductModel> _products;

        public ProductRepository() => _products = GetProducts();

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

        public void CreateProduct(int id, string? name, int count, double basePrice, int priceType)
        {
            var product = new ProductModel(id, name, count, basePrice, priceType);
            _products.Add(product);
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

        public Task UpdateProduct(int id)
        {
            var prod = GetProductById(id);
            var parameters = Interactions.GetUpdateParams();
            var newName = parameters[0];
            var newCount = Convert.ToInt32(parameters[1]);
            var newPrice = Convert.ToDouble(parameters[2]);
            prod.UpdateProductInfo(newName, newCount, newPrice);
            SaveProductList();
            return Task.CompletedTask;
        }

        public string SerializeProduct(ProductModel product) => $"{product.Id},{product.Name},{product.Count},{product.BasePrice},{product.PriceType}";
        

        public List<ProductModel> DeserializeProductList(List<string> _list)
        {
            var products = new List<ProductModel>();
            foreach (var line in _list)
            {
                string[] i = line.Split(',');

                if (i[4] == "PricePerKilogram") i[4] = "1";
                if (i[4] == "PricePer") i[4] = "0";
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

        private bool DoesProductexist(ProductModel product) => _products.Exists(p => p.Id == product.Id);
       
    }
}