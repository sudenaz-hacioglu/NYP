using System;
using System.Collections.Generic;

namespace AkilliEv
{
    enum CihazTuru
    {
        Lamba = 1,
        Klima = 2,
        GuvenlikSistemi = 3
    }

    class Cihaz
    {
        public int Kimlik { get; set; }
        public string Ad { get; set; }
        public CihazTuru Tur { get; set; }
        public bool AcikMi { get; set; }

        public Cihaz(int kimlik, string ad, CihazTuru tur)
        {
            Kimlik = kimlik;
            Ad = ad;
            Tur = tur;
            AcikMi = false;
        }

        public void Ac()
        {
            AcikMi = true;
        }

        public void Kapat()
        {
            AcikMi = false;
        }

        public void BilgileriGoster()
        {
            string durum = AcikMi ? "Açık" : "Kapalı";
            Console.WriteLine($"Kimlik: {Kimlik} | Ad: {Ad} | Tür: {Tur} | Durum: {durum}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Cihaz> cihazlar = new List<Cihaz>();

            cihazlar.Add(new Cihaz(1, "Salon Lambası", CihazTuru.Lamba));
            cihazlar.Add(new Cihaz(2, "Oda Kliması", CihazTuru.Klima));
            cihazlar.Add(new Cihaz(3, "Kapı Alarmı", CihazTuru.GuvenlikSistemi));

            while (true)
            {
                Console.WriteLine("\n1- Cihazları Listele");
                Console.WriteLine("2- Yeni Cihaz Ekle");
                Console.WriteLine("3- Cihaz Aç");
                Console.WriteLine("4- Cihaz Kapat");
                Console.WriteLine("0- Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    foreach (Cihaz c in cihazlar)
                    {
                        c.BilgileriGoster();
                    }
                }
                else if (secim == "2")
                {
                    Console.Write("Kimlik (ID): ");
                    int kimlik = Convert.ToInt32(Console.ReadLine());

                    bool varMi = false;
                    foreach (Cihaz c in cihazlar)
                    {
                        if (c.Kimlik == kimlik)
                        {
                            varMi = true;
                            break;
                        }
                    }

                    if (varMi)
                    {
                        Console.WriteLine("Bu kimliğe sahip bir cihaz zaten var.");
                        continue;
                    }

                    Console.Write("Cihaz Adı: ");
                    string ad = Console.ReadLine();

                    Console.WriteLine("Tür seçin (1: Lamba, 2: Klima, 3: GuvenlikSistemi): ");
                    int turNo = Convert.ToInt32(Console.ReadLine());

                    if (turNo < 1 || turNo > 3)
                    {
                        Console.WriteLine("Geçersiz tür seçimi.");
                        continue;
                    }

                    Cihaz yeniCihaz = new Cihaz(kimlik, ad, (CihazTuru)turNo);
                    cihazlar.Add(yeniCihaz);
                    Console.WriteLine("Cihaz eklendi.");
                }
                else if (secim == "3")
                {
                    Console.Write("Açılacak cihazın kimliği: ");
                    int kimlik = Convert.ToInt32(Console.ReadLine());

                    bool bulundu = false;
                    foreach (Cihaz c in cihazlar)
                    {
                        if (c.Kimlik == kimlik)
                        {
                            c.Ac();
                            Console.WriteLine("Cihaz açıldı.");
                            bulundu = true;
                            break;
                        }
                    }

                    if (!bulundu)
                    {
                        Console.WriteLine("Hata: Bu kimliğe sahip bir cihaz bulunamadı.");
                    }
                }
                else if (secim == "4")
                {
                    Console.Write("Kapatılacak cihazın kimliği: ");
                    int kimlik = Convert.ToInt32(Console.ReadLine());

                    bool bulundu = false;
                    foreach (Cihaz c in cihazlar)
                    {
                        if (c.Kimlik == kimlik)
                        {
                            c.Kapat();
                            Console.WriteLine("Cihaz kapatıldı.");
                            bulundu = true;
                            break;
                        }
                    }

                    if (!bulundu)
                    {
                        Console.WriteLine("Hata: Bu kimliğe sahip bir cihaz bulunamadı.");
                    }
                }
                else if (secim == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }
            }
        }
    }
}