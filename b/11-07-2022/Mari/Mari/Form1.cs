using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mari
{
    public partial class frmMari : Form
    {
        public frmMari()
        {
            InitializeComponent();
        }

        private void frmMari_Load(object sender, EventArgs e)
        {
            cmbFigura.Items.Add("Quadrato"); //aggiungo le figure creabili dall'utente
            cmbFigura.Items.Add("Rettangolo");
            cmbFigura.Items.Add("Triangolo");
            cmbFigura.SelectedIndex = 0; //il programma inizierá sempre con quadrato
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Figura f;
            try
            {
                if (cmbFigura.SelectedIndex == 0)
                {
                    if (tbDato1.Text == "")
                    {
                        wMsBox("Riempia tutti i campi");
                        return;
                    }
                    f = new Quadrato(Convert.ToDouble(tbDato1.Text));
                    iMsBox(f.Stampa());
                }
                else if(cmbFigura.SelectedIndex == 1)
                {
                    if (tbDato1.Text == "" || tbDato2.Text == "")
                    {
                        wMsBox("Riempia tutti i campi");
                        return;
                    }
                        
                    f = new Rettangolo(Convert.ToDouble(tbDato1.Text), Convert.ToDouble(tbDato2.Text));
                    iMsBox(f.Stampa());
                }
                else if(cmbFigura.SelectedIndex == 2)
                {
                    if (tbDato1.Text == "" || tbDato2.Text == "" || tbDato3.Text == "")
                    {
                        wMsBox("Riempia tutti i campi");
                        return;
                    }

                    f = new Triangolo(Convert.ToDouble(tbDato1.Text), Convert.ToDouble(tbDato2.Text), Convert.ToDouble(tbDato3.Text));
                    iMsBox(f.Stampa());
                }
            }
            catch(Exception ex)
            {
                eMsBox(ex.Message);
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

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Preparo la grafica in modo che vengano evidenziati solo i campi corretti
            if(cmbFigura.SelectedIndex == 0)
            {
                lblDato1.Enabled = true;
                lblDato1.Text = "Lato";
                tbDato1.Enabled = true;
                tbDato1.Text = "";

                //campo dato2

                lblDato2.Enabled = false;
                lblDato2.Text = "";
                tbDato2.Enabled = false;
                tbDato2.Text = "";

                //campo dato3

                lblDato3.Enabled = false;
                lblDato3.Text = "";
                tbDato3.Enabled = false;
                tbDato3.Text = "";
            }

            else if(cmbFigura.SelectedIndex == 1)
            {
                lblDato1.Enabled = true;
                lblDato1.Text = "Altezza";
                tbDato1.Enabled = true;
                tbDato1.Text = "";

                //campo dato2

                lblDato2.Enabled = true;
                lblDato2.Text = "Base";
                tbDato2.Enabled = true;
                tbDato2.Text = "";

                //campo dato3

                lblDato3.Enabled = false;
                lblDato3.Text = "";
                tbDato3.Enabled = false;
                tbDato3.Text = "";
            }

            else if (cmbFigura.SelectedIndex == 2)
            {
                lblDato1.Enabled = true;
                lblDato1.Text = "AB";
                tbDato1.Enabled = true;
                tbDato1.Text = "";

                //campo dato2

                lblDato2.Enabled = true;
                lblDato2.Text = "BC";
                tbDato2.Enabled = true;
                tbDato2.Text = "";

                //campo dato3

                lblDato3.Enabled = true;
                lblDato3.Text = "AC";
                tbDato3.Enabled = true;
                tbDato3.Text = "";
            }
        }
    }
}
