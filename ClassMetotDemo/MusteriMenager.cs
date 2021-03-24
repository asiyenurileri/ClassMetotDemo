using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMenager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! :" + musteri.Adi);
        }
        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Müşteri Sİlindi! :" + musteri.Adi);
        }
        public void Guncelle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi! :" + musteri.Adi);
        }
        
        public void Listele (Musteri[] musteri)
        {
            foreach (var m in musteri)
            {
                Console.WriteLine("* "+ m.Adi + " " + m.Soyadi + " " + m.TelefonNo + " " + m.Adres);
                
            }
        }
    }
}
