using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari
{
    internal class Figura
    {
        protected string tipofigura;
        protected int numerolati;
        protected double area, perimetro;

        public Figura()
        {
            tipofigura = "";
            numerolati = 0;
            area = 0.0;
            perimetro = 0.0;
        }

        public Figura(int numerolati) : this()
        {
            if (numerolati < 3)
                throw new Exception("Inserito numero non valdio");
            this.numerolati = numerolati;
            if (numerolati == 3)
                tipofigura = "Triangolo";
            else if (numerolati == 4)
                tipofigura = "Quadrilatero";
            else if (numerolati == 5)
                tipofigura = "Pentagono";
            else if (numerolati == 6)
                tipofigura = "Esagono";
            else
                tipofigura = "Poligono";
        }

        public int Numerolato
        {
            get { return numerolati; }
            set
            {
                if (value < 3)
                    throw new Exception("Inserito numero non valdio");
                numerolati = value;
                if (value == 3)
                    tipofigura = "Triangolo";
                else if (value == 4)
                    tipofigura = "Quadrilatero";
                else if (value == 5)
                    tipofigura = "Pentagono";
                else if (value == 6)
                    tipofigura = "Esagono";
                else
                    tipofigura = "Poligono";
            }
        }

        public virtual string Stampa()
        {
            return tipofigura +
                    "\nNumero lati: " + numerolati +
                    "\nArea: " + area +
                    "\nPerimetro";
        }
        public virtual string Stampa(string otherInfo)//Creata per avere i dati ordinati nella stampa via msbox
        {
            return tipofigura +
                    "\nNumero lati: " + numerolati + otherInfo
                    + "\nArea: " + area
                    + "\nPerimetro: " + perimetro;
                    
                    
        }
    }
}
