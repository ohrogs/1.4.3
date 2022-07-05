using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Sei sicuro?", "Rischiesta di conferma"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoNegozio.Text = comboBox1.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {//caricamento iniziale del form
            rdAbilita.Checked = true;
            comboBox1.Items.Add("Postale");
            chkData.Checked = true;
            chkOrario.Checked = true;
            lblOra.Text = System.DateTime.Now.ToLongTimeString();
            lblData.Text = System.DateTime.Today.ToShortDateString();
        }

        private void TipoNegozio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Abilita_Click(object sender, EventArgs e)
        {
            if (comboBox1.Enabled)
            {
                comboBox1.Enabled = false;
                Abilita.Text = "Abilita";
            }
            else
            {
                comboBox1.Enabled = true;
                Abilita.Text = "Disabilita";
            }

        }

        private void rdAbilita_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAbilita.Checked)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            
        }

        private void chkData_CheckedChanged(object sender, EventArgs e)
        {
            if(chkData.Checked)
            {
                lblData.Text = System.DateTime.Today.ToShortDateString();
                lblData.Visible = true;
            }
            else
            {
                lblData.Text = "";
                lblData.Visible = false;
            }
        }

        private void chkOrario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOrario.Checked)
            {
                lblOra.Text = System.DateTime.Now.ToLongTimeString();
                lblOra.Visible = true;
            }
            else
            {
                lblOra.Text = "";
                lblOra.Visible = false;
            }
        }
    }
}
