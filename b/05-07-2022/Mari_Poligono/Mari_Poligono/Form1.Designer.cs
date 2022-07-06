namespace Mari_Poligono
{
    partial class frmPoligono
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPoligono = new System.Windows.Forms.ComboBox();
            this.lblCombo = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.txtCampo1 = new System.Windows.Forms.TextBox();
            this.txtCampo2 = new System.Windows.Forms.TextBox();
            this.txtCampo3 = new System.Windows.Forms.TextBox();
            this.txtCampo4 = new System.Windows.Forms.TextBox();
            this.txtCampo5 = new System.Windows.Forms.TextBox();
            this.lblCampo5 = new System.Windows.Forms.Label();
            this.lblCampo4 = new System.Windows.Forms.Label();
            this.lblCampo3 = new System.Windows.Forms.Label();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPoligono
            // 
            this.cmbPoligono.FormattingEnabled = true;
            this.cmbPoligono.Location = new System.Drawing.Point(12, 55);
            this.cmbPoligono.Name = "cmbPoligono";
            this.cmbPoligono.Size = new System.Drawing.Size(121, 24);
            this.cmbPoligono.TabIndex = 0;
            this.cmbPoligono.SelectedIndexChanged += new System.EventHandler(this.cmbPoligono_SelectedIndexChanged);
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Location = new System.Drawing.Point(13, 25);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(102, 16);
            this.lblCombo.TabIndex = 1;
            this.lblCombo.Text = "Scelta Poligono";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(79, 364);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(142, 52);
            this.btnCalcola.TabIndex = 2;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // txtCampo1
            // 
            this.txtCampo1.Location = new System.Drawing.Point(172, 55);
            this.txtCampo1.Name = "txtCampo1";
            this.txtCampo1.Size = new System.Drawing.Size(100, 22);
            this.txtCampo1.TabIndex = 3;
            // 
            // txtCampo2
            // 
            this.txtCampo2.Location = new System.Drawing.Point(172, 99);
            this.txtCampo2.Name = "txtCampo2";
            this.txtCampo2.Size = new System.Drawing.Size(100, 22);
            this.txtCampo2.TabIndex = 4;
            // 
            // txtCampo3
            // 
            this.txtCampo3.Location = new System.Drawing.Point(172, 143);
            this.txtCampo3.Name = "txtCampo3";
            this.txtCampo3.Size = new System.Drawing.Size(100, 22);
            this.txtCampo3.TabIndex = 5;
            // 
            // txtCampo4
            // 
            this.txtCampo4.Location = new System.Drawing.Point(172, 187);
            this.txtCampo4.Name = "txtCampo4";
            this.txtCampo4.Size = new System.Drawing.Size(100, 22);
            this.txtCampo4.TabIndex = 6;
            // 
            // txtCampo5
            // 
            this.txtCampo5.Location = new System.Drawing.Point(172, 231);
            this.txtCampo5.Name = "txtCampo5";
            this.txtCampo5.Size = new System.Drawing.Size(100, 22);
            this.txtCampo5.TabIndex = 8;
            // 
            // lblCampo5
            // 
            this.lblCampo5.AutoSize = true;
            this.lblCampo5.Location = new System.Drawing.Point(169, 212);
            this.lblCampo5.Name = "lblCampo5";
            this.lblCampo5.Size = new System.Drawing.Size(52, 16);
            this.lblCampo5.TabIndex = 9;
            this.lblCampo5.Text = "Rombo";
            // 
            // lblCampo4
            // 
            this.lblCampo4.AutoSize = true;
            this.lblCampo4.Location = new System.Drawing.Point(169, 168);
            this.lblCampo4.Name = "lblCampo4";
            this.lblCampo4.Size = new System.Drawing.Size(52, 16);
            this.lblCampo4.TabIndex = 10;
            this.lblCampo4.Text = "Rombo";
            // 
            // lblCampo3
            // 
            this.lblCampo3.AutoSize = true;
            this.lblCampo3.Location = new System.Drawing.Point(169, 124);
            this.lblCampo3.Name = "lblCampo3";
            this.lblCampo3.Size = new System.Drawing.Size(52, 16);
            this.lblCampo3.TabIndex = 11;
            this.lblCampo3.Text = "Rombo";
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(169, 80);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(52, 16);
            this.lblCampo2.TabIndex = 12;
            this.lblCampo2.Text = "Rombo";
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(169, 36);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(52, 16);
            this.lblCampo1.TabIndex = 13;
            this.lblCampo1.Text = "Rombo";
            // 
            // frmPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.lblCampo2);
            this.Controls.Add(this.lblCampo3);
            this.Controls.Add(this.lblCampo4);
            this.Controls.Add(this.lblCampo5);
            this.Controls.Add(this.txtCampo5);
            this.Controls.Add(this.txtCampo4);
            this.Controls.Add(this.txtCampo3);
            this.Controls.Add(this.txtCampo2);
            this.Controls.Add(this.txtCampo1);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.cmbPoligono);
            this.Name = "frmPoligono";
            this.Text = "Poligoni";
            this.Load += new System.EventHandler(this.frmPoligono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPoligono;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.TextBox txtCampo1;
        private System.Windows.Forms.TextBox txtCampo2;
        private System.Windows.Forms.TextBox txtCampo3;
        private System.Windows.Forms.TextBox txtCampo4;
        private System.Windows.Forms.TextBox txtCampo5;
        private System.Windows.Forms.Label lblCampo5;
        private System.Windows.Forms.Label lblCampo4;
        private System.Windows.Forms.Label lblCampo3;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.Label lblCampo1;
    }
}

