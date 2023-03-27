using Inlamning2_TDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return  new List<CampaignModel>();
            }
        }


        public void CreateCampaign()
        {
            var _list = Interactions.GetCampaignInput();
            var sCampaign = DeserializeCampaignList(_list);
            _campaigns.AddRange(sCampaign);
        }

        private string SerializeCampaign(CampaignModel campaign)
        {
            return $"{campaign.ProductId},{campaign.FromDate},{campaign.ToDate},{campaign.Price}";
        }

        public List<CampaignModel> DeserializeCampaignList(List<string> _list)
        {
            var campaigns = new List<CampaignModel>();
            foreach (var line in _list)
            {
                string[] i = line.Split(',');
                CampaignModel x = new CampaignModel(
                    Convert.ToInt32(i[0]),
                    DateOnly.FromDateTime(Convert.ToDateTime(i[1])),
                    DateOnly.FromDateTime(Convert.ToDateTime(i[2])),
                    Convert.ToDouble(i[3])
                    );
                campaigns.Add(x);
            }
            return campaigns;
        }

        public void DeleteCampaign()
        {
            throw new NotImplementedException();
        }

        public void EditCampaign(CampaignModel campaign)
        {
            throw new NotImplementedException();
        }

        public string GetFilePath()
        {
            return CampPath;
        }

        public List<CampaignModel> GetCampaignsForProductById(int id)
        {
            return _campaigns.Where(x => x.ProductId == id).ToList();
        }
    }
}