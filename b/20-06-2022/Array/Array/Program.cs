using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vettore();
            matrice();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
        }

        private static void vettore()
        {
            Console.BackgroundColor = ConsoleColor.Green;

            int[] vettore; //é un riferimento come la stringa
            vettore = new int[5];


            for(int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = (i+1)*10;
                Console.Write(vettore[i] +" ");
            }
            Console.WriteLine();
        }

        private static void matrice()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            int[,] matrice = new int[3,5];
            //int [,] il numero di colonne é fisso x ogni riga
            //int [][] é un array di array, ogni riga puo avere un numero di colonne diverso

            RiempiMatrice(matrice);
            StampaMatrice(matrice);

            
        }

        static void RiempiMatrice(int[,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)//getlenght restituisce la lun della prima dim della stringa
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i,j] = (i+2)*(j+2)*10;
                }
            }
        }
        static void StampaMatrice(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)//getlenght restituisce la lun della prima dim della stringa
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
