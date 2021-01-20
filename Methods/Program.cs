using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Product Urun2 = new Product();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { Urun1, Urun2 };

            foreach (Product Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("---------Metotlar------------");
            CartManager sepetManager = new CartManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 12, 9);
            sepetManager.Ekle2("Elma", "Yeşil", 12, 5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 12, 4);
        }
    }
}
