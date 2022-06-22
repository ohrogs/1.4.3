using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinguaggio
{
    struct nuovotipo
    {

    }
    internal class Program
    {
        struct punto
        {
            public int x;
            public int y;

            public void Stampa()
            {
                Console.WriteLine(x + ", " + y);
            }
        }

        enum Giorni
        {
            Lunedi,
            Martedi,
            Mercoledi,
            Giovedi= 0,
            Venerdi,
            Sabato,
            Domenica
        }

        static void Main(string[] args)
        {
            arrei();

            Ternario();

            Conversioni();

            string s1 = "Marco";
            string s2 = s1;
            s1 = "Giovanni";

            punto p;

            p.x = 2;
            p.y = 5;
            p.Stampa();

            Giorni gg;

            //Giorni g = new Giorni();

            gg = Giorni.Sabato;

            string s = gg.ToString();

            Console.WriteLine(gg);



        }

        static void arrei()
        {
            int[] vettore;
            vettore = new int[5];

            //int[] vettore = new int[5];

            for (int i = 0; i < vettore.Length; i++)
                vettore[i] = i * 2 - 1;


            int[] vettore1 = { 1, 2, 3, 5, 7, 11, 13, 17 };

            int[] vettore2 = vettore1;

            int[,] matrice = new int[3, 5];

            RiempiMatrice(matrice);

            int[][] jarray = new int[4][];
            jarray[0] = new int[2];
            jarray[1] = new int[5];
            jarray[2] = new int[3];
            jarray[3] = new int[6];


            Suicc(2);


        }

        static void Suicc(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Tra 1 e 4");
                    break;
                default:
                    Console.WriteLine("Maggiore di 4");
                    break;
            }

        }


        static void RiempiMatrice(int[,] mat)
        {
            for (int i =0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = i - 3*j +4;


        }

        static void Ternario()
        {
            int x = 2;
            int y = 3;

            int risultato = (x > y) ? x : y;

            if (x > y)
                risultato = x;
            else
                risultato = y;
        
        }

        static void Conversioni()
        {
            long l = 1234567;

            int i = (int)l;

            byte b = (byte)i;

            string valore = "12321";

            int numero;

            if (int.TryParse(valore, out numero))
            {
                Console.WriteLine("Valore convertito = {0}", numero);
            }
            else
            {
                Console.WriteLine("Impossibile convertire = {0}", valore);

            }

            numero = Convert.ToInt32(valore);

            int num = 9;

            num %= 2;




        }
    }
}
