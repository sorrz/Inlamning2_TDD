using Inlamning2_TDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning2_TDD.Models
{
    internal class Campaign 
    {
        private static readonly string campPath = "campaigns.txt";
        public int Id { get; set; }
        public DateTime fromDate = new DateTime().Date;
        public DateTime toDate = new DateTime().Date;
        public double priceReduction { get; }
        public Campaign()
        {
            priceReduction = CheckForCampaign(campPath);
        }

        private static double CheckForCampaign(string campPath)
        {
            throw new NotImplementedException();
        }
    }
}
