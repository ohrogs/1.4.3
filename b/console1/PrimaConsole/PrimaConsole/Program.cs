using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Area rettangolo 3,4 = " + AreaRettangolo(3.0,4.0));
            Console.WriteLine("Area rettangolo 3,4 = {0}", AreaRettangolo(3.0, 4.0)); //lo 0 indica la posizione dei parametri dopo la ,
            Console.ReadKey();
        }

        static double AreaRettangolo(double b, double h)
        {
            return b * h;
        }
    }
}
