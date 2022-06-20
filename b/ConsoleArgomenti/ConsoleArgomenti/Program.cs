using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArgomenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SIUM");
            Console.WriteLine("il tuo nome é " + args[0]);
            String nome = Console.ReadLine();
            Console.WriteLine(AreaRettangolo(5,7) + " SDROGO");


            Console.ReadKey();//per concludere il programma
            
        }
        private static int AreaRettangolo(int lato1, int lato2)
        {
            return lato1 * lato2;
        }
    }
}
