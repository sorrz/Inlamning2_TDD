using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Interface
{
    public interface ICampaignRepository
    {
        void CreateCampaign(ProductModel product);
        void DeleteCampaign();
        void EditCampaign(CampaignModel campaign);
        string GetFilePath();
    }

}