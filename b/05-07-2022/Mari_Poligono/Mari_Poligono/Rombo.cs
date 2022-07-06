using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari_Poligono
{
    internal class Rombo : Poligono
    {
        private double l, dm, dM, r; //diagonale Maggiore minore

        public Rombo()
        {
            l = 0.0;
            dm = 0.0;
            dM = 0.0;
            r = 0.0;
            nome = "rombo";
        }

        public Rombo(double dm, double dM, double r, double l) : this()//costruttore con tutto
        {
            this.dm = dm;
            this.dM = dM;
            this.r = r;
            this.l = l;
            if (dm > dM)//le riordino se necessario
            {
                double aux = dm;
                dm = dM;
                dM = aux;
            }
        }

        public double L
        {
            get { return l; }
        }

        public double DM
        {
            get { return dM; }
        }
        
        public double Dm
        {
            get { return dm; }
        }

        public double R
        {
            get { return r; }
        }

        public double Perim()
        {
            return l * 4;
        }

        public override double Area()
        {
            return dArea();
        }

        public double dArea() //area con diagonali
        {
            return (dM * dm) / 2;
        }

        public double rlArea() //area con lato e raggio
        {
            return l * (2*r);
        }

        public override string Stampa()
        {
            return base.Stampa()
                + "\nl: " + l
                + "\nDiagonale Min: " + dm
                + "\nDiagonale Max: " + dM
                + "\n2p: " + Perim()
                + "\nA: " + Area();
        }
    }
}
