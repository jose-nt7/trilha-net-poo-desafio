using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca, int ano) 
            : base(numero, modelo, marca, ano)
        {
        }

                public override void InstalarAplicativo(string instagram)
        {
            Console.WriteLine($"Instalando o aplicativo {instagram} no Nokia {Modelo}...");
            
        }
    }
}
