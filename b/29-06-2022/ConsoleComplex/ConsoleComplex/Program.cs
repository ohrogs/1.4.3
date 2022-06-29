using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumeriComplessi;

namespace ConsoleComplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2), b = new Complex(2, 8);
            Console.WriteLine((a+b).ToString());
            Console.ReadKey();
        }
    }
}
