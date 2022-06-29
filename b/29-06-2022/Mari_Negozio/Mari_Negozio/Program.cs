using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari_Negozio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negozio n1 = new Negozio(), n2 = new Negozio("Forno", "a", "pineteria"); //passo dei parametri sbagliati per testare
            n1.Nome = "azienda s.r.l";
            n1.Partita = "abcdefghilm";
            n1.Tipo = "fruttaeverdura";
            Console.WriteLine("Stampo l'azienda 1");
            Console.WriteLine(n1.ToString());
            Console.WriteLine("\nStampo l'azienda 2");
            Console.WriteLine(n2.ToString());


            //inizio test parte supplementare
            Console.WriteLine("\nAggiungo 12 salse: ");
            for (int i = 0; i <= 11; i++)
            {
                n1.VariaProdotti("salsa" + i.ToString());
            }
            Console.WriteLine("\nStampo i prodotti:");
            n1.StampaProdotti();
            n1.VariaProdotti("salsa1");
            Console.WriteLine("\nStampo i prodotti dopo la rimozione di salsa1:");
            n1.StampaProdotti();
            n1.VariaProdotti("salsa2");
            Console.WriteLine("\nStampo i prodotti dopo la rimozione di salsa2:");
            n1.StampaProdotti();
            n1.svuota();
            Console.WriteLine("\nStampo l'array dopo svuota:");
            n1.StampaProdotti();
            pause();
        }

        private static void pause()
        {
            Console.WriteLine("\nPrema un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
