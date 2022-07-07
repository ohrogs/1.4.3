using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARI_FATTURE
{
    internal class FatturaRitenuta : Fattura
    {
        private const double ritenuta = 0.2;

        public FatturaRitenuta() : base()
        {
            tipo = "ritenuta";
        }

        public FatturaRitenuta(DateTime data, double importounitario, double quantita) : base(data, importounitario, quantita)
        {
            tipo = "ritenuta";
            nettodapagare = totale + (totale * ritenuta);
        }

        public override void CalcolaNetto()
        {
            nettodapagare = totale + (totale * ritenuta);
        }
    }
}
