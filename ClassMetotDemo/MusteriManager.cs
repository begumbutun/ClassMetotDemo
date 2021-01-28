using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi : " + musteri.ID + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.tutar + musteri.meslek);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.ID + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.tutar + musteri.meslek);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi : " + musteri.ID + musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.tutar + musteri.meslek);
        }
    }
}
