using GameBackEnd.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Concrete
{
    internal class NewCampaignManager:ICampaignService
    {
        public void RunCampaign()
        {
            {
                Console.WriteLine("Yeni Kampanya Oluşturuldu!");
            }

        }
    }
}
