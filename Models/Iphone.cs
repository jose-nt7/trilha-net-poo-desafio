using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string marca, int ano) 
            : base(numero, modelo, marca, ano)
        {
        }

        
        public override void InstalarAplicativo(string WhatsApp)
        {
            Console.WriteLine($"Instalando o aplicativo {WhatsApp} no iPhone {Modelo}...");
            
        }
    }
}
