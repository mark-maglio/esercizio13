using System;

namespace Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il prezzo del primo prodotto: ");
            double prezzo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il prezzo del secondo prodotto: ");
            double prezzo2 = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            double totale;
            if (prezzo1 > prezzo2)
            {
                sconto = prezzo2 / 100 * 50;
                scontato = prezzo2 - sconto;
                totale = prezzo1 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            else
            {
                sconto = prezzo1 / 100 * 50;
                scontato = prezzo1 - sconto;
                totale = prezzo2 + scontato;
                Console.WriteLine($"Lo sconto è di {sconto} euro e il prezzo da pagare {totale} euro");
            }
            Console.WriteLine("arrivederci");
            Console.ReadLine();
        }
    }
}