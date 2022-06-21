using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUKT
{
    internal class Program
    {
        struct punto
        {
            public int x;
            public int y;

            public void Stampa()
            {
                Console.WriteLine("(" + x + "; " + y + ")");
            }
        }

        enum Giorni
        {
            Lunedi = 1,
            Martedi,
            Mercoledi,
            Giovedi,
            Venerdi,
            Sabato,
            Domenica //Sará 7
        }
        static void Main(string[] args)
        {
            Console.Title = "SIUUUUU";
            Conversioni();
            tryparse();
            opternario();
            String s1 = "Vamo raga";
            //Sulla stack cé il punatore s1 che punta a vamo raga sulla heap
            String s2 = s1;
            //Creo un nuovo puntatore e ci metto dentro l'indirizzo di vamo raga nella heap
            s1 = "altro";
            //Vamo raga non si é cancellato
            //ora s1 punta ad altro mentre s2 ancora a vamo raga;
            punto punto; //esiste e occupa gia lo spazio
            punto.x = 1;
            punto.y = 2;
            punto.Stampa();
            Console.WriteLine(Giorni.Lunedi + " = " + (int)Giorni.Lunedi);
            Console.ReadKey();
        }

        static void Conversioni()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            long l = 1234567;

            int i = (int)l;

            int k = (int)l;

            byte b = (byte)i;

            Console.WriteLine(Convert.ToBoolean(l));
            Console.WriteLine(Convert.ToString(b));
            Console.WriteLine(Convert.ToInt32("6969"));
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        static void tryparse()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;

            int numero;

            if(int.TryParse("15.3", out numero))
            {
                Console.WriteLine("Valore convertito = " + numero);
            }
            else
            {
                Console.WriteLine("SEI UN COGLIONE");
            }
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }

        static void opternario()
        {
            Console.BackgroundColor = ConsoleColor.Green;

            int x = 2;
            int y = 3;
            int risultato = (x > y) ? x : y;
            //Se x > y risultato = x
            //Altrimento risultato = y
            Console.WriteLine(risultato);

            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
    }
}
