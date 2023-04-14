using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Interface
{
    public interface ICampaignRepository
    {
        void CreateCampaign();
        Task DeleteCampaign(int campID);
        Task EditCampaign(int campID);
        string GetFilePath();
        List<CampaignModel> GetCampaignsForProductById(int id);
    }

}