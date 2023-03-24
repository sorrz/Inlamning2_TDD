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
        public double Price { get; private set; }
        public List<CampaignModel> Campaigns { get; private set; }

        public PriceTypeEnum PriceType { get; private set; }
      
        public ProductModel(int id, string? name, int count, double basePrice, int priceType)
        {
            Id = id;
            Name = name;
            Count = count;
            BasePrice = basePrice;
            PriceType = GetPriceType(priceType);
            Campaigns = new List<CampaignModel>();
        }

        private void GetCampaignPrice(ProductModel product)
        {
            Price = campaignRepository.GetCampaignPrice(product);
        }

        public PriceTypeEnum GetPriceType(int typeID)
        {
            if (typeID == 1) return PriceTypeEnum.PricePerKilogram;
            else return PriceTypeEnum.PricePer;
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