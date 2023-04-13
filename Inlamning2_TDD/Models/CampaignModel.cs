using Inlamning2_TDD.Interface;

using Inlamning2_TDD.Repository;
using System.Xml.Linq;

namespace Inlamning2_TDD.Models
{
    public class CampaignModel
    {
        private ICampaignRepository _campaignRepository;
        public int CampId { get; set; }
        public int ProductId { get; set; }
        public DateOnly FromDate { get; private set; }
        public DateOnly ToDate { get; private set; }
        public double Price { get; set; }

        public CampaignModel(int campID, int productId, DateOnly from, DateOnly to, double price)
        {
            CampId = campID;
            FromDate = from;
            ToDate = to;
            ProductId = productId;
            Price = price;
        }

        public CampaignModel()
        {
            
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
        public void UpdateCampaignInfo(int newProdID, DateOnly newStart, DateOnly newEnd, Double newPrice)
        {
            ProductId = newProdID;
            FromDate = newStart;
            ToDate = newEnd;
            Price = newPrice;

        }
    }
}