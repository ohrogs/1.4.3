using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari
{
    internal class Rettangolo : Figura
    {
        private double b, h;

        public Rettangolo() : base(4)
        {
            tipofigura = "Rettangolo";
            b = 0.0;
            h = 0.0;
        }

        public Rettangolo(double b, double h) : base(4)
        {
            if(b <= 0.0 || h <= 0.0)
                throw new Exception("Inserito numero non valdio");
            else if(b == h) //l'utente potrebbe inserire un quadrato anche nei campi rettangolo
                throw new Exception("Questo é un quadrato");
            tipofigura = "Rettangolo";
            this.b = b;
            this.h = h;
            Area();//RICALCOLO
            Perimetro();
        }

        public double H
        {
            get { return h; }
            set
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                h = value;
                Area();//RICALCOLO
                Perimetro();
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                b = value;
                Area();//RICALCOLO
                Perimetro();
            }
        }

        private void Area()
        {
            area = b * h;
        }

        private void Perimetro()
        {
            perimetro = 2.0 * (b + h);
        }

        public override string Stampa()
        {
            return base.Stampa("\nBase: " + b
                                +"\nAltezza: " + h);
        }

    }
}
