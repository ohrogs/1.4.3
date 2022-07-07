using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARI_FATTURE
{
    internal class Fattura
    {//É stato simulato un progresivo utilizzando una int statica protetta
        protected string tipo;
        protected static int numero = 0;//progressivo
        protected int anno;
        protected DateTime data;
        protected double importounitario, quantita, totale, nettodapagare;
        protected const double iva = 0.22;

        public Fattura()
        {
            tipo = "ordinaria";
            data = DateTime.Now;
            numero++;
            importounitario = 0.0;
            quantita = 0.0;
            totale = 0.0;
            nettodapagare = 0.0;
        }

        public Fattura(DateTime data, double importounitario, double quantita)
        {
            tipo = "ordinaria";
            if(data <= DateTime.Now)
                this.data = data;
            else
                throw new Exception("Inserire una data valida");
            anno = Convert.ToInt32(DateTime.Now.Year);
            if (importounitario > 0.0)
                this.importounitario = importounitario;
            else
                throw new Exception("Inserire numeri > 0 nel campo Importo Unitario");
            if (quantita > 0.0)
                this.quantita = quantita;
            else
                throw new Exception("Inserire numeri > 0 nel campo Quantitá");
            totale = quantita * importounitario;
            nettodapagare = (totale) + (totale*iva);
            //CalcolaNetto();
            numero++;
        }

        public DateTime Data
        {
            get { return data; }
            set {
                if (value <= DateTime.Now)
                    data = value;
                else
                    throw new Exception("Inserire una data valida");
            }
        }

        public double Importounitario
        {
            get { return importounitario; }
            set {
                if (value > 0.0)
                    importounitario = value;
                else
                    throw new Exception("Inserire numeri > 0 nel campo Importo Unitario" );
            }
        }

        public double Quantita
        {
            get { return quantita; }
            set {
                if (value > 0.0)
                    quantita = value;
                else
                    throw new Exception("Inserire numeri > 0 nel campo Quantitá" + quantita.GetType().Name);
            }
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public double Totale
        {
            get { return totale; }
        }

        public double Nettodapagare
        {
            get { return nettodapagare; }
        }

        public virtual void CalcolaNetto()
        {
            nettodapagare = totale + (totale * iva);
        }

        public virtual string Stampa()
        {
            return "Progressivo: " + numero
                    + "\nTipo: " + tipo
                    + "\nAnno Corrente: " + anno
                    + "\nData: " + data.ToShortDateString()
                    + "\nImporto Unitario: " + importounitario
                    + "\nQuantita: " + quantita
                    + "\nTotale: " + totale
                    + "\nNetto da pagare: " + nettodapagare;
                    
        }

    }
}
