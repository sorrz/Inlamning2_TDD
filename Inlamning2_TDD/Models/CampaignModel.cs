using Inlamning2_TDD.Interface;

using Inlamning2_TDD.Repository;

namespace Inlamning2_TDD.Models
{
    public class CampaignModel
    {
        private ICampaignRepository _campaignRepository;
        
        public int ProductId { get; set; }
        public DateOnly FromDate { get;  }
        public DateOnly ToDate { get;  }
        public double Price { get; set; }

        public CampaignModel(int productId, DateOnly from, DateOnly to, double price)
        {
            FromDate = from;
            ToDate = to;
            ProductId = productId;
            Price = price;
        }
        // TODO: Probably Not Needed
        public int SetRequestID(ProductModel product)
        {
            return product.Id;
        }
        // TODO: Probably Not Needed
        public double CheckForCampaign()
        {
            return 1d;
        }
    }
}