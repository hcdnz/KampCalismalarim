using GameBackEnd.Abstract;
using GameBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd.Concrete
{
    internal class OrderManager
    {
        public void Order(Gamer gamer, ICampaignService campaignService)
        {

            campaignService.RunCampaign();

            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "İsimli Oyuncuya Kampanya Tanımlandı!");
        }
    }
}
