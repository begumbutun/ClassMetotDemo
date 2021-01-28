using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager MusteriManager= new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.ID = 7009;
            musteri1.MusteriAdi = "Begüm";
            musteri1.MusteriSoyadi = "Bütün";
            musteri1.meslek = "öğrenci";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 987;
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Bütün";
            musteri2.meslek = "yönetici";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 302;
            musteri3.MusteriAdi = "Aynur";
            musteri3.MusteriSoyadi = "Bütün";
            musteri3.meslek = "Dış Ticaret müdürü";

            Musteri musteri4 = new Musteri();
            musteri4.ID = 500;
            musteri4.MusteriAdi =  "BENGÜ";
            musteri4.MusteriSoyadi =   "BÜTÜN";
            musteri4.meslek =   "PAZARLAMACI";

            MusteriManager.Ekle(musteri4);
            MusteriManager.Ekle(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach(Musteri x in musteriler)
            {
                MusteriManager.Listele(musteri1);
                
            }

            MusteriManager.Sil(musteri2);
                
        }
    }
}
