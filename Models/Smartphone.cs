using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }

        
        public Smartphone(string numero, string modelo, string marca, int ano)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        
        public abstract void InstalarAplicativo(string WhatsApp);
        public void MostrarDados()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Ano: {Ano}");
        }

    }
}
