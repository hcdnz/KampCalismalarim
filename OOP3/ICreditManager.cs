using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager  
    // * Bir class bu interface'i kullannırsa içerisinde bulunan operasyonları kullanmak zorunda.
    // * Birbirinin alternatifi olan fakat kod içeriği farklı olan işlemler için kullanılır.
    // * Kodların arasında boğulmadan basitçe yeni bir operasyon ekleyebilmek için kullanılır.
    {
        void Calculate(); // Hesapla

       
    }
}
