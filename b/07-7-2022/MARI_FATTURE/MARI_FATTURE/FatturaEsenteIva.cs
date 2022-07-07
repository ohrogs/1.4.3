using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARI_FATTURE
{
    internal class FatturaEsenteIva : Fattura
    {
        public FatturaEsenteIva() : base()
        {
            tipo = "esente iva";
        }

        public FatturaEsenteIva(DateTime data, double importounitario, double quantita) : base(data, importounitario, quantita)
        {
            nettodapagare = totale;
        }

        public override void CalcolaNetto()
        {
            nettodapagare = totale;
        }
    }
}
