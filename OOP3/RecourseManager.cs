using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RecourseManager 
    {
        public void RecourseMake(ICreditManager creditManager, ILoggerService loggerService)
        // Interface referance olarak verdiğimiz için, inheritindeki class'larla çalışabiliriz.
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate(); // İstenilen kredi türüne göre hesaplamayı yap anlamına gelir.
            loggerService.Log(); // Hangi Log'layıcı service gönderilmişse onu Log'la anlamıa gelir.
        }

        public void CreditOnBilgilendirmesiYap(List<ICreditManager> credits) 
        // Birden fazla kredi hesabını yapabilmek için bütün kredileri kapsayan bir liste istedik.
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
