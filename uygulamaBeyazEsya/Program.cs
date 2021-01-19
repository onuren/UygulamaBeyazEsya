using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamaBeyazEsya
{
    class Program
    {
        static void Main(string[] args)
        {
            islemler i = new islemler();

            string exit = "e";
            while (exit=="e")
            {
                Console.WriteLine("Ekleyeceğiniz ürünü seçiniz:");
                Console.WriteLine("1. Buzdolabı");
                Console.WriteLine("2. Çamaşır Makinesi");
                Console.WriteLine("3. Bulaşık Makinesi");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    buzdolabi buz = new buzdolabi();
                    Console.WriteLine("Marka:");
                    buz.marka = Console.ReadLine();
                    Console.WriteLine("Model:");
                    buz.model = Console.ReadLine();
                    Console.WriteLine("Hacim:");
                    buz.hacim = Console.ReadLine();
                    Console.WriteLine("Fiyat:");
                    buz.fiyat = Convert.ToDouble(Console.ReadLine());

                    i.Ekle(buz);
                }
                else if (secim == "2")
                {
                    camasir cam = new camasir();
                    Console.WriteLine("Marka:");
                    cam.marka = Console.ReadLine();
                    Console.WriteLine("Model:");
                    cam.model = Console.ReadLine();
                    Console.WriteLine("Yıkama Kapasitesi:");
                    cam.yikamaKapasitesi = Console.ReadLine();
                    Console.WriteLine("Fiyat:");
                    cam.fiyat = Convert.ToDouble(Console.ReadLine());

                    i.Ekle(cam);
                }
                else if (secim == "3")
                {
                    bulasik bul = new bulasik();
                    Console.WriteLine("Marka:");
                    bul.marka = Console.ReadLine();
                    Console.WriteLine("Model:");
                    bul.model = Console.ReadLine();
                    Console.WriteLine("Program sayısı:");
                    bul.programSayisi = Console.ReadLine();
                    Console.WriteLine("Fiyat:");
                    bul.fiyat = Convert.ToDouble(Console.ReadLine());

                    i.Ekle(bul);
                }
                else
                {
                    Console.WriteLine("Lütfen tekrar deneyiniz.");
                }
                Console.WriteLine("Eklemeye devam edilsin mi?");
                exit = Console.ReadLine();
            }
            i.YazdirBulasik();
            i.YazdirBuzdolabı();
            i.YazdirCamasir();
        }
    }
}
