using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVeicoli
{
    internal class VeicoliMotore
    {
        const int LUNGHEZZATARGA = 7, LUNGHEZZAPROPRIETARIO = 7;
        //attributi privati
        private string targa, proprietario, motore;
        private DateTime dataImmatricolaz;

        public string Targa
        {
            get { return targa; }
            set
            {
                if (value.Length == LUNGHEZZATARGA)
                    targa = value;
                else
                    targa = null;
            }
        }

        public string Proprietario
        {
            get { return proprietario; }
            set
            {
                if (proprietario.Length >= LUNGHEZZAPROPRIETARIO)
                    proprietario = value;
            }
        }

        public DateTime DataImmatricolaz
        {
            get { return dataImmatricolaz; }
            set
            {
                if (dataImmatricolaz <= DateTime.Today)
                    dataImmatricolaz = value;
            }
        }

        public string Motore
        {
            get { return motore; }
            set
            {
                if(value == "comb" || value=="elett")
                    motore = value;
            }
        }
        public VeicoliMotore()
        {
            targa = "";
            proprietario = "sconosciuto";
            DataImmatricolaz = DateTime.Today;
            motore = "combustione";
        }

        public VeicoliMotore(string targa) : this()
        {
            if(targa.Length == LUNGHEZZATARGA)
                this.targa = targa;
        }

        public VeicoliMotore(string targa, string proprietario) : this(targa)
        {
            if(proprietario.Length >= LUNGHEZZAPROPRIETARIO)
                this.proprietario = proprietario;
        }

        public VeicoliMotore(string targa, string proprietario, DateTime dataImmatricolaz) : this(targa, proprietario)
        {
            if(DataImmatricolaz <= DateTime.Today)
                this.dataImmatricolaz = dataImmatricolaz;
        }
        public VeicoliMotore(string targa, string proprietario, DateTime dataImmatricolaz, string motore) : this(targa, proprietario, dataImmatricolaz)
        {
            if (motore == "comb" || motore == "elett")
                this.motore = motore;
        }
        public string Stampa()
        {
            return "Targa veicolo = " + targa + "\n"
            + "Proprietario = " + proprietario + "\n"
            + "Motore = " + motore + "\n"
            + "Data Immatricolazione = " + dataImmatricolaz;
        }
    }
}
