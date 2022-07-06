using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVeicoli
{
    internal class VeicoliMotore
    {
        //attributi privati
        private string targa;
        private string proprietario;
        private DateTime dataimmatricolazione;
        protected string motore;

        private const int LUNGHEZZATARGA = 7;
        private const int LUNGHEZZAPROPRIETARIO = 5;


        //Costruttori
        public VeicoliMotore()
        {
            targa = "";
            proprietario = "sconosciuto";
            dataimmatricolazione = DateTime.Today;
            motore = "combustione";
        }

        public VeicoliMotore(string targa) : this()
        {
            if (targa.Length == LUNGHEZZATARGA)
                this.targa = targa;
        }

        public VeicoliMotore(string targa, string proprietario) : this(targa)
        {
            if (proprietario.Length >= LUNGHEZZAPROPRIETARIO)
                this.proprietario = proprietario;
        }

        public VeicoliMotore(string targa, string proprietario, DateTime dataimmatricolazione)
            : this(targa, proprietario)
        {
            if (dataimmatricolazione <= DateTime.Today)
                this.dataimmatricolazione = dataimmatricolazione; ;
        }

        public VeicoliMotore(string targa, string proprietario,
                             DateTime dataimmatricolazione, string motore)
            : this(targa, proprietario, dataimmatricolazione)
        {
            if ((motore == "combustione") || (motore == "elettrico"))
                this.motore = motore;
        }



        //Property
        public string Targa
        {
            get
            {
                return targa;
            }
            set
            {
                if (value.Length == LUNGHEZZATARGA)
                    targa = value;
            }


        }
        public string Proprietario
        {
            get
            {
                return proprietario;
            }
            set
            {
                if (value.Length >= LUNGHEZZAPROPRIETARIO)
                    proprietario = value;
            }


        }
        public DateTime Dataimmatricolazione
        {
            get
            {
                return dataimmatricolazione;
            }
            set
            {
                if (value <= DateTime.Today)
                    dataimmatricolazione = value;
            }


        }
        public string Motore
        {
            get
            {
                return motore;
            }
            set
            {
                if ((value == "combustione") || (value == "elettrico"))
                    motore = value;
            }


        }

        //Metodi pubblici
        public virtual string Stampa()//virtual serve per poter avere override
        {
            string testo = "Targa veicolo: " + targa + "\n";
            testo += "Proprietario: " + proprietario + "\n";
            testo += "Motore: " + motore + "\n";
            testo += "Immatricolato il " + dataimmatricolazione.ToShortDateString();

            return testo;
        }
    }
    internal class VeicoliCombustione : VeicoliMotore
    {
        private string combustibile;
        private int cilindrata;


        public VeicoliCombustione()
        {
            motore = "combustione";
            combustibile = "benzina";
            cilindrata = 1000;
        }

        public VeicoliCombustione(string targa, string proprietario, DateTime dataimmatricolazione, string combustibile, int cilindrata) : base(targa, proprietario, dataimmatricolazione, "combustione")
        {
            this.combustibile = combustibile;
            this.cilindrata = cilindrata;
        }

        public string Combustibile{
            get {return combustibile;}
            set
            {
                combustibile = value;
            }
        }

        public int Cilindrata
        {
            get {return cilindrata;}
            set
            {
                if (value > 0)
                    cilindrata = value;
                else
                    cilindrata = 0;
            }
        }

        public override string Stampa()
        {
            return base.Stampa() + "\nCombustibile: " + combustibile + "\n"
                + "Cilindrata: " + cilindrata;
        }


    }
}
