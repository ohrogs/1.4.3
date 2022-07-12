using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari
{
    internal class Triangolo : Figura
    {
        private double ab, bc, ac;

        public Triangolo() : base(3)
        {
        }

        public Triangolo(double ab, double bc, double ac) : base(3)
        {
            if(ab <= 0 || bc <= 0 || ac <= 0)
                throw new Exception("Inserito numero non valdio");
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Perimetro();
            Area();
        }

        public double Ab
        {
            get { return ab; }
            set 
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                ab = value;
                Perimetro();//RICALCOLO
                Area();
            }
        }

        public double Bc
        {
            get { return bc; }
            set
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                bc = value;
                Perimetro();//RICALCOLO
                Area();
            }
        }

        public double Ac
        {
            get { return ac; }
            set
            {
                if (value <= 0)
                    throw new Exception("Inserito numero non valdio");
                ac = value;
                Perimetro();//RICALCOLO
                Area();
            }
        }

        private void Area()
        {
            double p = perimetro / 2;
            double c = p * (p - ab) * (p - bc) * (p - ac);
            area = Math.Sqrt(c); //formula trovata su google, fonte in fondo
        }

        private void Perimetro()
        {
            perimetro = ab + bc + ac;
        }

        public override string Stampa()
        {
            return base.Stampa("\nBase: " + ab
                               +"\nLato2: " + bc
                               + "\nLato3: " + ac);
        }
    }
}

//fonte formula area: https://www.youmath.it/formulari/formulari-di-geometria-piana/406-tutte-le-formule-sul-triangolo-qualsiasi.html
//                    https://docs.microsoft.com/it-it/dotnet/api/system.math.sqrt?view=net-6.0
