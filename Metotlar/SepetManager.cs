using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   public class SepetManager // Manager class ları genellikle metotları bir arada tutar.
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler! Sepete Eklendi : " + urun.Adi+ "/" + urun.Aciklama);
        }

    }
}
