using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;
            int due, tre, quattro;
            int[] elenco = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            potenze(a, out due, out tre, out quattro);
            scambia(ref a, ref b);
            CalcolaPotenze(a, elenco);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        static void scambia(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = a;
        }

        static void potenze(int a, out int due, out int tre, out int quattro)
        {
            due = a * a;
            tre = due * a;
            quattro = tre * a;
        }

        static void CalcolaPotenze(int a, params int[]potenze)
        {
            foreach(int x in potenze)
            {
                int p = (int)Math.Pow(a, x);
                Console.Write(p + " ");
            }
            Console.WriteLine("");
        }
    }
}
