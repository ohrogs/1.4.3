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
        private DateTime dataNascita;
        private String cf;


        //Properties

        public int Eta
        {
            get 
            {
                return eta;
            }
            set
            {
                eta = value;
            }
        }
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

        public DateTime DataNascita
        {
            get { return dataNascita; }
            set {
                if(value <= DateTime.Today)
                    dataNascita = value; 
            }
        }        


        //metodi
        public Persona()
        {
            eta = 0;
            nome = null;
            cognome = null;
            cf = null;
            dataNascita = DateTime.Today;
        }

        public Persona(string nome, string cognome)
        {
            eta = 0;
            this.nome = nome;
            this.cognome = cognome;
            cf = null;
            dataNascita = DateTime.Today;
        }

        public Persona(string nome, string cognome, string cf)
        : this(nome, cognome)//richiama il costruttore scritto sopra
        {
            eta = 0;
            this.cf = cf;
            dataNascita = DateTime.Today;
        }

        public Persona(int eta, string nome, string cognome, string cf, DateTime dataNascita)
        {
            this.eta = eta;
            this.nome = nome;
            this.cognome = cognome;
            this.cf = cf;
            this.dataNascita = dataNascita;
        }
        public String GetInfo()
        {
            return nome + " " + cognome + ", " + eta;
        }
    }
}
