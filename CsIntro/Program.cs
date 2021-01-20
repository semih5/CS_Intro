using System;

namespace CsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri Tipleri
            string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 23000;  Sayı
            //double ogrenciSayisii= 21.45; ondalıklıSayılar
            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
