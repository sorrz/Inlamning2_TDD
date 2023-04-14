using Inlamning2_TDD.Interface;
using Inlamning2_TDD.Models;

namespace Inlamning2_TDD.Repository
{
    internal class CampaignRepository : ICampaignRepository
    {
        private static readonly string CampPath = "campaigns.txt";
        private List<CampaignModel> _campaigns;

        public CampaignRepository()
        {
            _campaigns = GetCampaigns();
        }

        private List<CampaignModel> GetCampaigns()
        {
            if (File.Exists(CampPath))
            {
                var _list = File.ReadAllLines(CampPath).ToList();
                return DeserializeCampaignList(_list);
            }
            else
            {
                return new List<CampaignModel>();
            }
        }


        public void CreateCampaign()
        {
            var _list = Interactions.GetCampaignInput();
            var sCampaign = DeserializeOneCampaign(_list);
            _campaigns.AddRange(sCampaign);
            SaveCampaignList();
        }

        private string SerializeCampaign(CampaignModel campaign) => $"{campaign.CampId},{campaign.ProductId},{campaign.FromDate},{campaign.ToDate},{campaign.Price}";


        public List<CampaignModel> DeserializeCampaignList(List<string> _list)
        {
            var campaigns = new List<CampaignModel>();
            foreach (var line in _list)
            {
                string[] i = line.Split(',');
                CampaignModel x = new CampaignModel(
                    Convert.ToInt32(i[0]),
                    Convert.ToInt32(i[1]),
                    DateOnly.FromDateTime(Convert.ToDateTime(i[2])),
                    DateOnly.FromDateTime(Convert.ToDateTime(i[3])),
                    Convert.ToDouble(i[4])
                );
                campaigns.Add(x);
            }

            return campaigns;
        }

        public List<CampaignModel> DeserializeOneCampaign(List<string> _list)
        {
            var campaigns = new List<CampaignModel>();


            string[] i = _list.ToArray();
            CampaignModel x = new CampaignModel(
                Convert.ToInt32(i[0]),
                Convert.ToInt32(i[1]),
                DateOnly.FromDateTime(Convert.ToDateTime(i[2])),
                DateOnly.FromDateTime(Convert.ToDateTime(i[3])),
                Convert.ToDouble(i[4])
            );
            campaigns.Add(x);


            return campaigns;
        }

        public Task DeleteCampaign(int campID)
        {
            foreach (CampaignModel camp in _campaigns)
            {
                if (campID == camp.CampId)
                {
                    _campaigns.Remove(camp);
                    break;
                }
                
            }
            SaveCampaignList();
            return Task.CompletedTask;
        }

        public Task EditCampaign(int campID)
        {
            CampaignModel activeCampaign = new();
            foreach (CampaignModel camp in _campaigns)
            {
                if (campID == camp.CampId)
                {
                    activeCampaign = camp;
                    break;
                }
            }


            var parameters = Interactions.GetCampaignInput();
            var newProdID = Convert.ToInt32(parameters[0]);
            var newStart = DateOnly.FromDateTime(Convert.ToDateTime(parameters[1]));
            var newEnd = DateOnly.FromDateTime(Convert.ToDateTime(parameters[1]));
            var newPrice = Convert.ToDouble(parameters[3]);

            activeCampaign.UpdateCampaignInfo(newProdID, newStart, newEnd, newPrice);
            SaveCampaignList();
            return Task.CompletedTask;
        }

        private void SaveCampaignList()
        {
            var result = new List<string>();
            foreach (CampaignModel camp in _campaigns) result.Add(SerializeCampaign(camp));
            File.WriteAllLines(CampPath, result.ToArray());
        }

        public string GetFilePath() => CampPath;


        public List<CampaignModel> GetCampaignsForProductById(int id) => _campaigns.Where(x => x.ProductId == id).ToList();

    }
}