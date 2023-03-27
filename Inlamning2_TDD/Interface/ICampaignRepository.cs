using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Interface
{
    public interface ICampaignRepository
    {
        void CreateCampaign();
        void DeleteCampaign();
        void EditCampaign(CampaignModel campaign);
        string GetFilePath();
        List<CampaignModel> GetCampaignsForProductById(int id);
    }

}