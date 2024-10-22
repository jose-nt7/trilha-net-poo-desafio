using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Smartphone nokia = new Nokia("123456789", "Nokia 3310", "Nokia", 2000);
        nokia.Ligar();
        nokia.InstalarAplicativo("instagram");
        nokia.MostrarDados();
        

        Console.WriteLine(); 

        
        Smartphone iphone = new Iphone("947454825", "iPhone 12", "Apple", 2020);
        iphone.Ligar();
        iphone.InstalarAplicativo("whatsapp");
        iphone.MostrarDados();
    }
}
