//Bilgisayar Sistemi

using System;

class Islemci
{
    public string Model { get; set; }

    public int CekirdekSayisi { get; set; }

    public Islemci(string model, int cekirdekSayisi)
    {
        Model = model;
        CekirdekSayisi = cekirdekSayisi;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} islemci calisti.");
    }
}

class Bilgisayar
{
    public string Marka { get; set; }

    public Islemci islemci;

    public Bilgisayar(string marka, string islemciModeli, int cekirdekSayisi)
    {
        Marka = marka;
        islemci = new Islemci(islemciModeli, cekirdekSayisi);
    }

    public void Ac()
    {
        Console.WriteLine($"{Marka} bilgisayar aciliyor.");
        islemci.Calistir();
    }

    public void BilgileriGoster()
    {
        Console.WriteLine($" Islemci : {islemci.Model}");
        Console.WriteLine($" Cekirdek : {islemci.CekirdekSayisi}");
    }
}

class Program
{
    static void Main()
    {
        Bilgisayar bilgisayar = new Bilgisayar("Dell", "Intel i7", 8);
        bilgisayar.BilgileriGoster();
        Console.WriteLine();
        bilgisayar.Ac();
    }
}