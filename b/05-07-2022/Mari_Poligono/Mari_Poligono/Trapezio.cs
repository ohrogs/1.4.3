using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari_Poligono
{
    internal class Trapezio : Poligono
    {
        private double bm, bM, l1, l2, h;
        public Trapezio()
        {
            nome = "trapezio";
            bm = 0.0;
            l1 = 0.0;
            l2 = 0.0;
            bM = 0.0;
            h = 0.0;
        }

        public Trapezio(double bm, double bM, double l1, double l2, double h) : this()
        {
            this.bm = bm;
            this.bM = bM;
            this.l1 = l1;
            this.l2 = l2;
            this.h = h;
        }

        private double Perim()
        {
            return bm + bM + l1 + l2;
        }

        public override double Area()
        {
            return ((bm + bM) * h) / 2;
        }

        public override string Stampa()
        {
            return base.Stampa()
                + "\nl1: " + l1
                + "\nl2: " + l2
                + "\nBase Min: " + bm
                + "\nBase Max: " + bM
                + "\n2p: " + Perim()
                + "\nA: " + Area();
        }
    }
}
