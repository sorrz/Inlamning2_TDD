using Inlamning2_TDD.Interface;

using Inlamning2_TDD.Repository;

namespace Inlamning2_TDD.Models
{
    public class CampaignModel
    {
        private ICampaignRepository _campaignRepository;

        public Guid Id { get; private set; }
        public DateOnly FromDate { get;  }
        public DateOnly ToDate { get;  }

        public int ProductId { get; set; }
        public double Price { get; set; }

        public CampaignModel(int productId, DateOnly from, DateOnly to, double price)
        {
            FromDate = from;
            ToDate = to;
            _campaignRepository = new CampaignRepository();
            Id = new Guid();
            ProductId = productId;
            Price = price;
        }

        public int SetRequestID(ProductModel product)
        {
            return product.Id;
        }

        private double CheckForCampaign(string campPath, int productId)
        {
            throw new NotImplementedException();
        }
    }
}