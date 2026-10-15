using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia(
            "123456789", "Nokia 3310", "Nokia", 2000
        );

        Console.WriteLine("=== NOKIA ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Instagram");
        nokia.MostrarDados();

        Console.WriteLine();

        Smartphone iphone = new Iphone(
            "947454825", "iPhone 12", "Apple", 2020
        );

        Console.WriteLine("=== IPHONE ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
        iphone.MostrarDados();
    }
}