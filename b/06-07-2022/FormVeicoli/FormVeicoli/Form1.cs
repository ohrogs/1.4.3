using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVeicoli
{
    public partial class frmVeicoli : Form
    {
        public frmVeicoli()
        {
            InitializeComponent();
        }

        private void btnVeicolo_Click(object sender, EventArgs e)
        {
            VeicoliMotore v = new VeicoliMotore(txtTarga.Text, txtProprietario.Text, dtImmatricolazione.Value, cmbMotore.SelectedText);
            /*v.Proprietario = txtProprietario.Text;
            v.Targa=txtTarga.Text;
            v.Motore = cmbMotore.SelectedItem.ToString();
            v.Dataimmatricolazione = dtImmatricolazione.Value;*/

            StampaVeicolo(v);
        }


        private void StampaVeicolo(VeicoliMotore vm)
        {
            MessageBox.Show(vm.Stampa());
        }//fatta dal prof

        private void btnVeicoloCombustione_Click(object sender, EventArgs e)
        {
            VeicoliCombustione vc = new VeicoliCombustione(txtTarga.Text, txtProprietario.Text, dtImmatricolazione.Value, txtCombustibile.Text, Convert.ToInt32(txtCilindrata.Text));

            StampaVeicolo(vc);
        }

        private void lblCombustibile_Click(object sender, EventArgs e)
        {

        }
    }
}
