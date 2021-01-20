using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi." + urun.Adi);
        }
        public void Ekle2(string urunAdi, string urunAciklamasi, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler sepete eklendi;  " + urunAdi);
        }
    }
}
