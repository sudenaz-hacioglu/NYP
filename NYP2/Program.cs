//Araba Sistemi

using System;

class Motor
{
    public string Model { get; set; }

    public int BeygirGucu { get; set; }

    public Motor(string model, int beygirGucu)
    {
        Model = model;
        BeygirGucu = beygirGucu;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Model} motor calisti.");
    }
}

class Araba
{
    public string Marka { get; set; }

    public Motor AracMotoru;

    public Araba(string marka, Motor motor)
    {
        Marka = marka;
        AracMotoru = motor;
    }

    public void Calistir()
    {
        Console.WriteLine($"{Marka} marka araba çalışıyor.");
        AracMotoru.Calistir();
    }
}

class Program
{
    static void Main()
    {
        Motor motor = new Motor("1.6 Tdi", 115);
        Araba araba = new Araba("Volkswagen", motor);
        Console.WriteLine();
        araba.Calistir();
    }
}