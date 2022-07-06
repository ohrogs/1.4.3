using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mari_Poligono
{
    public partial class frmPoligono : Form
    {
        public frmPoligono()
        {
            InitializeComponent();
        }

        private void frmPoligono_Load(object sender, EventArgs e)
        {
            cmbPoligono.Items.Add("Trapezio");
            cmbPoligono.Items.Add("Rombo");
            //cmbPoligono.SelectedIndex = 0;
            lblCampo1.Enabled = false;
            lblCampo1.Text = "";
            lblCampo2.Enabled = false;
            lblCampo2.Text = "";
            lblCampo3.Enabled = false;
            lblCampo3.Text = "";
            lblCampo4.Enabled = false;
            lblCampo4.Text = "";
            lblCampo5.Enabled = false;
            lblCampo5.Text = "";
            txtCampo1.Enabled = false;
            txtCampo2.Enabled = false;
            txtCampo3.Enabled = false;
            txtCampo4.Enabled = false;
            txtCampo5.Enabled = false;
        }

        private void cmbPoligono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPoligono.SelectedIndex == 0)//caso trapezio
            {
                lblCampo1.Enabled = true;
                lblCampo1.Text = "Base Maggiore";
                lblCampo2.Enabled = true;
                lblCampo2.Text = "Base Minore";
                lblCampo3.Enabled = true;
                lblCampo3.Text = "Lato 1";
                lblCampo4.Enabled = true;
                lblCampo4.Text = "Lato 2";
                lblCampo5.Enabled = true;
                lblCampo5.Text = "Altezza";
                txtCampo1.Enabled = true;
                txtCampo2.Enabled = true;
                txtCampo3.Enabled = true;
                txtCampo4.Enabled = true;
                txtCampo5.Enabled = true;

            }
            else if(cmbPoligono.SelectedIndex == 1)//caso rombo
            {
                lblCampo1.Enabled = true;
                lblCampo1.Text = "Base Maggiore";
                lblCampo2.Enabled = true;
                lblCampo2.Text = "Base Minore";
                lblCampo3.Enabled = true;
                lblCampo3.Text = "Lato 1";
                lblCampo4.Enabled = true;
                lblCampo4.Text = "Lato 2";
                lblCampo5.Enabled = false;
                lblCampo5.Text = "";
                txtCampo1.Enabled = true;
                txtCampo2.Enabled = true;
                txtCampo3.Enabled = true;
                txtCampo4.Enabled = true;
                txtCampo5.Enabled = false;
            }
            else
            {
                lblCampo1.Enabled = false;
                lblCampo2.Enabled = false;
                lblCampo3.Enabled = false;
                lblCampo4.Enabled = false;
                lblCampo5.Enabled = false;
                txtCampo1.Enabled = false;
                txtCampo2.Enabled = false;
                txtCampo3.Enabled = false;
                txtCampo4.Enabled = false;
                txtCampo5.Enabled = false;
            }
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if (cmbPoligono.SelectedIndex == 0)//caso trapezio
            {
                //MsBox(txtCampo1.Text);
                if (txtCampo1.Text == "" || txtCampo2.Text == "" || txtCampo3.Text == "" || txtCampo4.Text == "" || txtCampo5.Text == "")
                {
                    aMsBox("RIEMPIRE TUTTI I CAMPI");
                    return;
                }
                Trapezio t = new Trapezio(Convert.ToDouble(txtCampo1.Text), Convert.ToDouble(txtCampo2.Text), Convert.ToDouble(txtCampo3.Text), Convert.ToDouble(txtCampo4.Text), Convert.ToDouble(txtCampo5.Text));
                MsBox(t.Stampa());
            }
            else if (cmbPoligono.SelectedIndex == 1)//caso rombo
            {
                if (txtCampo1.Text == "" || txtCampo2.Text == "" || txtCampo3.Text == "" || txtCampo4.Text == "")
                {
                    aMsBox("RIEMPIRE TUTTI I CAMPI");
                    return;
                }
                Rombo r = new Rombo(Convert.ToDouble(txtCampo1.Text), Convert.ToDouble(txtCampo2.Text), Convert.ToDouble(txtCampo3.Text), Convert.ToDouble(txtCampo4.Text));
                MsBox(r.Stampa());
            }
            else
            {
                lblCampo1.Enabled = false;
                lblCampo2.Enabled = false;
                lblCampo3.Enabled = false;
                lblCampo4.Enabled = false;
                lblCampo5.Enabled = false;
                txtCampo1.Enabled = false;
                txtCampo2.Enabled = false;
                txtCampo3.Enabled = false;
                txtCampo4.Enabled = false;
                txtCampo5.Enabled = false;
            }

        }

        private void MsBox(string s)
        {
            MessageBox.Show(s, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void aMsBox(string s)
        {
            MessageBox.Show(s, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
