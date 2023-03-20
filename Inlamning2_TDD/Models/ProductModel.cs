using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Repository;
using System.Xml;

namespace Inlamning2_TDD.Models
{
    public class ProductModel
    {
        private ICampaignRepository campaignRepository;

        public int Id { get; } 
        public string? Name { get; private set; }
        public int Count { get; private set; }
        public double BasePrice { get; private set; }
        private double Price { get; set; } = 0;

        //public ProductModel()
        //{
        //    Id = getId();
        //    Name = Name;
        //    Count = Count;
        //    BasePrice = BasePrice;
        //    Price = GetBestPrice();
        //    campaignRepository = new campaignRepository();
        //}

        public ProductModel(int id, string? name, int count, double basePrice)
        {
            Id = id;
            Name = name;
            Count = count;
            BasePrice = basePrice;
            //Price= GetBestPrice();
        }

        private double GetBestPrice()
        {
            if (campaignRepository is null)
            {
                throw new ArgumentNullException(nameof(campaignRepository));
            }

            throw new NotImplementedException();
        }

        private int getId()
        {
            var id = 0;
            return id;
        }

        public void IncreaseCount(int count)
        {
            Count += count;
        }

        public void UpdateProductInfo(string productName, int count, double basePrice)
        {
            Name = productName;
            Count = count;
            BasePrice = basePrice;
        }
        
    }
}