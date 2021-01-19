using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamaBeyazEsya
{
    class islemler
    {
        public buzdolabi[] buz;
        public camasir[] cam;
        public bulasik[] bul;

        public islemler()
        {
            buz = new buzdolabi[0];
            cam = new camasir[0];
            bul = new bulasik[0];
        }

        public void Ekle(buzdolabi urun)
        {
            buzdolabi[] gecici = new buzdolabi[buz.Length + 1];
            Array.Copy(buz, gecici, buz.Length);
            gecici[gecici.Length - 1] = urun;
            buz = gecici;
        }

        public void Ekle(camasir urun)
        {
            camasir[] gecici = new camasir[bul.Length + 1];
            Array.Copy(cam, gecici, cam.Length);
            gecici[gecici.Length - 1] = urun;
            cam = gecici;
        }
        public void Ekle(bulasik urun)
        {
            bulasik[] gecici = new bulasik[bul.Length + 1];
            Array.Copy(bul, gecici, bul.Length);
            gecici[gecici.Length - 1] = urun;
            bul = gecici;
        }

        public void YazdirCamasir()
        {
            foreach (var item in cam)
            {
                Console.WriteLine("----------Çamaşır Makineleri----------");
                Console.WriteLine(item.marka + " " + item.model + " " + item.yikamaKapasitesi + " " + item.fiyat+" TL");
            }
        }
        public void YazdirBulasik()
        {
            foreach (var item in bul)
            {
                Console.WriteLine("----------Bulaşık Makineleri----------");
                Console.WriteLine(item.marka + " " + item.model + " " + item.programSayisi + " " + item.fiyat+" TL");
            }
        }
        public void YazdirBuzdolabı()
        {
            foreach (var item in buz)
            {
                Console.WriteLine("------------Buzdolapları------------");
                Console.WriteLine(item.marka + " " + item.model + " " + item.hacim + " " + item.fiyat+" TL");
            }
        }
    }
}
