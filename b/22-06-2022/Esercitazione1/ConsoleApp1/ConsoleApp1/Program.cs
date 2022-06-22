using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length <= 0)
                Console.WriteLine("Missing arguments...");
            else if(args.Length == 1)
            {
                if(int.TryParse(args[0], out int value))
                    StampaNumeri(value);
                else
                    Console.WriteLine("Errore non é stato passato un numero intero");
            }
            else
            {
                if (double.TryParse(args[1], out double temperatura)) //la temp puo'essere con decimali
                {
                    //Console.WriteLine(temperatura);
                    StampaFrase(temperatura, args[0]);
                }
            }
            pause();
        }

        private static void StampaFrase(double numero, String testo)
        {
            String inizio = ("Ciao " + testo + ", la tua temperatura é " + numero);
            if (numero < 35.0)
                Console.WriteLine(inizio + " e sei in ipotermia");
            else if (numero >= 35.0 && numero < 38.0)
                Console.WriteLine(inizio + " e stai bene");
            else
                Console.WriteLine(inizio + " e hai la febbre");
        }

        private static void StampaNumeri(int dim)
        {
            Console.WriteLine("Stampo i numeri in colonna:");
            for(int i = 0; i < dim; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void pause()
        {
            Console.WriteLine("Prema un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
