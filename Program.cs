using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Tek satırda hem yarat, hem doldur.
        Savasci asker1 = new Savasci("Barbar", 100, 25);
        Savasci asker2 = new Savasci("Okcu", 80, 40);
        asker1.Saldir(asker2); // Barbar, Okçu'ya saldırsın.

        asker1.BilgiGoster();
        asker2.BilgiGoster();
    }
    /*
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
        */
}
class Savasci
{
    //Properties
    public string Isim;
    public int Can;
    public int HasarGucu;
    public void Saldir(Savasci hedef)
    {
        hedef.Can -= HasarGucu;
        Console.WriteLine(Isim + " saldırıyor ve " + hedef.Isim + "'e " + HasarGucu + " hasar veriyor!");
        Console.WriteLine(hedef.Isim + " kalan cani: " + hedef.Can);
    }
    // --- CONSTRUCTOR ---
    public Savasci(string isim, int can, int guc)
    {
        Isim = isim;
        Can = can;
        HasarGucu = guc;
    }
    public void BilgiGoster()
    {
        // Kendi içindeki Isim ve Can değişkenlerini doğrudan kullanır.
        Console.WriteLine("Karakter: " + Isim + " | Can: " + Can + " | Hasar Gücü: " + HasarGucu);
    }
}
