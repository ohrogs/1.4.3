using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mari_Negozio
{
    internal class Negozio
    {
        private string nome, partitaiva, tipo;
        private string[] prodotti;
        private int numprodotti;

        public int Numprodotti
        {
            get { return numprodotti; }
        }
        public string Nome { 
            get { return nome; }
            set { nome = value; }
        }

        public string Partita{ 
            get { return partitaiva; }
            set {
                if (value.Length == 11)
                    partitaiva = value;
                else
                    partitaiva = "Ignota";
            }
        }

        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (value != "fruttaeverdura" && value != "panetteria" && value != "macelleria")
                    tipo = "NonDefinito";
                else
                    tipo = value;
            }
        }

        public Negozio()
        {
            nome = "";
            tipo = "NonDefinito";
            partitaiva = "Ignota";
            numprodotti = 0;
            prodotti = new string[10];
        }

        public Negozio(string nome) : this()
        {
            this.nome = nome;
        }

        public Negozio(string nome, string partitaiva) : this(nome)
        {
            if (partitaiva.Length == 11)
                this.partitaiva = partitaiva;
            else
                partitaiva = "Ignota";
        }

        public Negozio(string nome, string partitaiva, string tipo) : this(nome, partitaiva)
        {
            if (tipo != "fruttaeverdura" && tipo != "panetteria" && tipo != "macelleria")
                this.tipo = "NonDefinito";
            else
                this.tipo = tipo;
        }

        public override string ToString()
        {
            return nome + ", " + partitaiva + ", " + tipo;
        }

        public void VariaProdotti(string prod)
        {

            if(isIn(prod, out int pos))
            {
                Remove(pos);
            }
            else
            {
                Append(prod);
            }
        }

        private void Append(string s)
        {
            //Console.WriteLine(numprodotti);
            if (prodotti.Length == numprodotti)
            {
                Console.WriteLine("array pieno");
                return;
            }
                prodotti[numprodotti++] = s;
            //numprodotti++;
        }

        private void Remove(int pos)
        {
            prodotti[pos] = null;
            numprodotti--;
            for(int i = pos; i < numprodotti; i++)
            {
                prodotti[i] = prodotti[i+1];
            }
        }

        public bool isIn(string comp)//isin base
        {
            foreach(string s in prodotti)
            {
                if(s == comp)
                    return true;
            }
            return false;
        }

        public bool isIn(string comp, out int pos)//isin che restituisce anche la pos
        {
            pos = 0;
            for(int i = 0; i < numprodotti; i++)
            {
                if(prodotti[i] == comp)
                {
                    pos = i;
                    return true;
                }
            }
            return false;
        }

        public void StampaProdottiRaw()
        {
            foreach(string s in prodotti)
            {
                Console.WriteLine(s);
                if(s == null)
                {
                    return;
                }
            }
        }

        public void StampaProdotti()
        {
            for (int i = 0; i < numprodotti; i++)
            {
                Console.Write(prodotti[i]+ " ");
            }
            Console.WriteLine();
        }

        public void svuota()
        {
            if (numprodotti == 0)
                return;
            else
            {
                numprodotti = 0;
                prodotti = null;
                prodotti = new string[10];
            }
        }
    }
}
