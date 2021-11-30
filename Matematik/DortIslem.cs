using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
        public void Cıkar(int sayi1, int sayi2)
        {
            int cıkar = sayi1 - sayi2;
            Console.WriteLine(cıkar);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine(carp);
        }
        public void Bol(int sayi1,int sayi2)
        {
            double bol = sayi1 / sayi2;
            Console.WriteLine(bol);
        }
         
    }
}
