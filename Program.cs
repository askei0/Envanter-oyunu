using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int oyuncuCan = 100;
        int dusmanCan = 100;
        int turSayisi = 1;
    
        Selamla();
        BaslangicEkrani();

        while (oyuncuCan > 0 && dusmanCan > 0)
        {
            Console.WriteLine("Tur: " + turSayisi);
            int value = RastgeleHasarUret(10, 25);
            dusmanCan -= value;
            Console.WriteLine("Oyuncu dusmana " + value + " hasar verdi.");
            if (dusmanCan <= 0)
            {
                Console.WriteLine("Dusman yenildi!");
                break;
            }
            value = RastgeleHasarUret(5, 20);
            oyuncuCan -= value;
            Console.WriteLine("Dusman oyuncuya " + value + " hasar verdi.");
            if (oyuncuCan <= 0)
            {
                Console.WriteLine("Oyuncu yenildi!");
                break;
            }
            Console.WriteLine("Dusmanin kalan cani: " + dusmanCan);
            Console.WriteLine("Oyuncunun kalan cani: " + oyuncuCan);
            Console.WriteLine("2. tura gecmek icin enter'a basiniz.");
            Console.ReadLine(); 
            turSayisi++;
            Console.WriteLine("----------------------");
        }

            BitisEkrani();
/*
        HasarVer("Goblin", 20);
        int value = RastgeleHasarUret(10, 30);
        Console.WriteLine("Rastgele uretilen hasar: " + value);
        int gelenSayi = KritikVurusYap(50);
        Console.WriteLine("Kritik vuruş sonucu: " + gelenSayi);
        HasarVer("Ejderha", 50);
        BitisEkrani();
*/
    }

    static int RastgeleHasarUret(int min, int max)
    {
        Random zar = new Random();
        int value = zar.Next(min, max);
        return value;
    }
    static int KritikVurusYap(int safHasar)
    {
        int sonuc = safHasar * 2;
        return sonuc;
    }
    static void HasarVer(string dusmanAdi, int hasarMik)
    {
        Console.WriteLine(dusmanAdi + " sana saldirdi ve " + hasarMik + " hasar verdi!");
    }
    static void Selamla()
    {
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("----------------------");
    }
    static void BaslangicEkrani()
    {
        Console.WriteLine("gladyator arena, Version: 1.2. Baslamak icin enter'a basiniz.");
        Console.ReadLine();
    }
    static void BitisEkrani()
    {
        Console.WriteLine("Oyun bitti. Thanks for playing! :) (yazilimci: askei)");
    }
}
