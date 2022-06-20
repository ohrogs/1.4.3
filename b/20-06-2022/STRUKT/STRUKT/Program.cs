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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "SIUUUUU";
            Conversioni();
            punto punto; //esiste e occupa gia lo spazio
            punto.x = 1;
            punto.y = 2;
            punto.Stampa();
            Console.WriteLine(Giorni.Lunedi + " = " + (int)Giorni.Lunedi);
            Console.ReadKey();
        }

        static void Conversioni()
        {
            long l = 1234567;

            int i = (int)l;

            int k = (int)l;

            byte b = (byte)i;
        }
    }
}
