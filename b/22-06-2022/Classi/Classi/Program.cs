using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(18, "carlo", "brozzo", "ABA", DateTime.Today);
            Console.WriteLine(persona.GetInfo());
            persona.Cognome = "culo";
            Console.WriteLine(persona.GetInfo().ToString());
            pause();
        }

        private static void pause()
        {
            Console.WriteLine("Premere un tasto per continuare");
            Console.ReadKey();
        }
    }
}
