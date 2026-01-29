using System;
using System.Collections.Generic; // LİSTE İÇİN BUNU EKLEMEN ŞART!

class Program
{
    static void Main(string[] args)
    {
        // 1. Listeyi Oluştur
        List<string> envanter = new List<string>();

        // 2. Eşyaları Ekle
        envanter.Add("Kılıç");
        envanter.Add("Kalkan");
        envanter.Add("İksir");

        // 3. Sayıyı Yazdır (.Count)
        Console.WriteLine("Çantada şu an " + envanter.Count + " eşya var.");

        // 4. İksiri Sil
        envanter.Remove("İksir");

        // 5. Son Durumu Yazdır
        Console.WriteLine("İksir içildi. Kalan eşya sayısı: " + envanter.Count);
    }
}