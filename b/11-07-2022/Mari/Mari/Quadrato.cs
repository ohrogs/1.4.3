using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari
{
    internal class Quadrato : Figura
    {
        private double lato;

        public Quadrato() : base(4)
        {
            tipofigura = "Quadrato";
            lato = 0.0;
        }

        public Quadrato(double lato) : base(4)
        {
            if (lato <= 0)
                throw new Exception("Inserito numero non valdio");
            this.lato = lato;
            tipofigura = "Quadrato";
            Area();//RICALCOLO
            Perimetro();
        }

        public double Lato
        {
            get { return lato; }
            set 
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                lato = value;
                Area();//RICALCOLO
                Perimetro();
            }
        }

        private void Area()
        {
            area = lato * lato;
        }

        private void Perimetro()
        {
            perimetro = lato * 4.0;
        }

        public override string Stampa()
        {
            return base.Stampa("\nLato: " +  lato);
        }
    }
}
