using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARI_FATTURE
{
    public partial class frmFatture : Form
    {
        public frmFatture()
        {
            InitializeComponent();
        }

        private void frmFatture_Load(object sender, EventArgs e)
        {
            cmbFattura.Items.Add("Fattura");
            cmbFattura.Items.Add("Fattura scaricata");
            cmbFattura.Items.Add("Fattura ritenuta");
            cmbFattura.SelectedIndex = 0;
        }

        private void cmbFattura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninserimento_Click(object sender, EventArgs e)
        {
            if (tbimportounitario.Text == "" || tbimportounitario.Text == "")
                wMsBox("Riempia tutti i campi");
            else
            {
                try
                {
                    if(cmbFattura.SelectedIndex == 0)
                    {
                        Fattura f = new Fattura(dtpData.Value, Convert.ToDouble(tbimportounitario.Text), Convert.ToDouble(tbquantita.Text));
                        iMsBox(f.Stampa());
                    }
                    else if(cmbFattura.SelectedIndex == 1)
                    {
                        FatturaEsenteIva f = new FatturaEsenteIva(dtpData.Value, Convert.ToDouble(tbimportounitario.Text), Convert.ToDouble(tbquantita.Text));
                        iMsBox(f.Stampa());
                    }
                    else if (cmbFattura.SelectedIndex == 2)
                    {
                        FatturaRitenuta f = new FatturaRitenuta(dtpData.Value, Convert.ToDouble(tbimportounitario.Text), Convert.ToDouble(tbquantita.Text));
                        iMsBox(f.Stampa());
                    }
                    else
                    {
                        eMsBox("Errore sul Menu a tendina");
                    }

                }
                catch (Exception ex)
                {
                    eMsBox(ex.Message);
                    return;
                }
            }
        }

        private void wMsBox(string msg)
        {
            MessageBox.Show(msg, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void eMsBox(string msg)
        {
            MessageBox.Show(msg, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iMsBox(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
