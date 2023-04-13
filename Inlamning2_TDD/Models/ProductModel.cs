using Inlamning2_TDD.Repository;


namespace Inlamning2_TDD.Models
{
    public class ProductModel
    {
        private CampaignRepository campaignRepository;

        public int Id { get; private set; } 
        public string? Name { get; private set; }
        public int Count { get; private set; }
        public double BasePrice { get; private set; }
        public double Price { get; private set; }
        public List<CampaignModel> Campaigns { get; private set; }

        public PriceTypeEnum PriceType { get; private set; }
      
        public ProductModel(int id, string? name, int count, double basePrice, int priceType)
        {
            campaignRepository = new CampaignRepository();
            Id = id;
            Name = name;
            Count = count;
            BasePrice = basePrice;
            PriceType = GetPriceType(priceType);
            Campaigns = campaignRepository.GetCampaignsForProductById(id);
        }
        
        
        public double GetCampaignPrice()
        {
            double currentPrice = BasePrice;
            foreach (CampaignModel _camp in Campaigns)
            {
                if (_camp.FromDate < DateOnly.FromDateTime(DateTime.Today) &&
                    _camp.ToDate > DateOnly.FromDateTime(DateTime.Today))
                {
                   currentPrice = _camp.Price < BasePrice ? _camp.Price : BasePrice;
                }
            }
            return currentPrice;
        }

        public PriceTypeEnum GetPriceType(int typeID) => 
            (typeID == 1) ? PriceTypeEnum.PricePerKilogram : PriceTypeEnum.PricePer;
        
        public void IncreaseCount(int count) => Count += count;

        public void UpdateProductInfo(string productName, int count, double basePrice)
        {
            Name = productName;
            Count = count;
            BasePrice = basePrice;
        }

        

    }
}