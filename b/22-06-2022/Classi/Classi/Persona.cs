using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    internal class Persona
    {
        private int eta;
        private string nome;
        private string cognome;
        private String cf;


        //Properties
        public String Cognome
        {
            get 
            {
                return cognome;
            }
            set
            {
                if(value.Length >= 2)
                    cognome = value;
            } 
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        //metodi
        public Persona()
        {
            eta = 0;
            nome = null;
            cognome = null;
            cf = null;
        }
        public Persona(int eta, string nome, string cognome, string cf)
        {
            this.eta = eta;
            this.nome = nome;
            this.cognome = cognome;
            this.cf = cf;
        }
        public String GetInfo()
        {
            return nome + " " + cognome + ", " + eta;
        }
    }
}
