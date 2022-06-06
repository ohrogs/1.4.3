using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinguaggio
{
    internal class Program
    {
        struct punto
        {
            public double x;
            public double y;
        }
        enum Giorni
        {
            Lunedi,Martedi,Mercoledi,Giovedi,Venerdi,Sabato,Domenica
        }
        static void Main(string[] args)
        {
            punto p;
            Giorni a = Giorni.Giovedi;
            p.x = 1.0;
            p.y = 2.0;
            Console.WriteLine("(" + p.x + ", " + p.y + ")");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
