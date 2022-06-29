using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriComplessi
{
    public class Complex
    {
        private double re;
        private double im;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public Complex()
        {
            re = 0;
            im = 0;
        }

        public Complex(double re)
        {
            this.re = re;
            im = 0;
        }

        public Complex(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        public override string ToString()//subordina la funzione ereditata
        {
            return re + " + j" + im + " ";
        }

        /*public Complex Sum(Complex z1, Complex z2)
        {
            return new Complex();
        }*/

        public static Complex operator +(Complex z1, Complex z2)
        {
            Complex z = new Complex();
            z.re = z1.re + z2.re;
            z.im = z1.im + z2.im;
            return z;

        }


    }
}
