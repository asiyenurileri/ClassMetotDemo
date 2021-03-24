using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Merve";
            musteri1.Soyadi = "Kır";
            musteri1.TelefonNo = 2548793156;
            musteri1.Adres = "Ankara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Emine";
            musteri2.Soyadi = "Onat";
            musteri2.TelefonNo = 6598742301;
            musteri2.Adres = "Kayseri";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Işıl";
            musteri3.Soyadi = "Soytürk";
            musteri3.TelefonNo = 0622879314;
            musteri3.Adres = "Sivas";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ayşe";
            musteri4.Soyadi = "Aydıngün";
            musteri4.TelefonNo = 7854630211;
            musteri4.Adres = "Hatay";
            
            MusteriMenager musteriMenager = new MusteriMenager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("-----------Müşteri Ekle----------");
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);
            musteriMenager.Ekle(musteri3);
            musteriMenager.Ekle(musteri4);
            Console.WriteLine(" ");
            Console.WriteLine("-----------Müşteri Güncelle----------");
            musteriMenager.Guncelle(musteri2);
            Console.WriteLine(" ");
            Console.WriteLine("-----------Müşteri Sil---------- -");
            musteriMenager.Sil(musteri4);
            Console.WriteLine(" ");
            Console.WriteLine("-----------Müşterileri Listele---------");
            musteriMenager.Listele(musteriler);
            Console.ReadLine();
        }
    }
}
