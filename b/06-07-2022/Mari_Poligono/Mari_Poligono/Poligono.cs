using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari_Poligono
{
    
    internal class Poligono
    {
        protected string nome;
        

        public Poligono()
        {
            nome = "";
        }

        public Poligono(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get { return nome; }
        }

        public virtual double Area()
        {
            return 0.0;
        }

        public virtual string Stampa()
        {
            return nome;
        }
    }
}
