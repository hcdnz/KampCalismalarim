using GameBackEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Concrete
{
    public class UpdateCampaignManager:ICampaignService
    {
        public void RunCampaign()
        {
            Console.WriteLine("Kampanya Başarıyla Eklendi!");
        }
    }
}
