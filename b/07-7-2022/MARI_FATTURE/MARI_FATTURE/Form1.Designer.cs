namespace MARI_FATTURE
{
    partial class frmFatture
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
            this.cmbFattura = new System.Windows.Forms.ComboBox();
            this.lblcmbFatture = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbldtpData = new System.Windows.Forms.Label();
            this.lblimportounitario = new System.Windows.Forms.Label();
            this.tbimportounitario = new System.Windows.Forms.TextBox();
            this.tbquantita = new System.Windows.Forms.TextBox();
            this.lblquantita = new System.Windows.Forms.Label();
            this.btninserimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFattura
            // 
            this.cmbFattura.FormattingEnabled = true;
            this.cmbFattura.Location = new System.Drawing.Point(12, 32);
            this.cmbFattura.Name = "cmbFattura";
            this.cmbFattura.Size = new System.Drawing.Size(148, 24);
            this.cmbFattura.TabIndex = 0;
            this.cmbFattura.SelectedIndexChanged += new System.EventHandler(this.cmbFattura_SelectedIndexChanged);
            // 
            // lblcmbFatture
            // 
            this.lblcmbFatture.AutoSize = true;
            this.lblcmbFatture.Location = new System.Drawing.Point(13, 13);
            this.lblcmbFatture.Name = "lblcmbFatture";
            this.lblcmbFatture.Size = new System.Drawing.Size(79, 16);
            this.lblcmbFatture.TabIndex = 1;
            this.lblcmbFatture.Text = "Tipo Fattura";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 85);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(231, 22);
            this.dtpData.TabIndex = 2;
            // 
            // lbldtpData
            // 
            this.lbldtpData.AutoSize = true;
            this.lbldtpData.Location = new System.Drawing.Point(13, 66);
            this.lbldtpData.Name = "lbldtpData";
            this.lbldtpData.Size = new System.Drawing.Size(36, 16);
            this.lbldtpData.TabIndex = 3;
            this.lbldtpData.Text = "Data";
            // 
            // lblimportounitario
            // 
            this.lblimportounitario.AutoSize = true;
            this.lblimportounitario.Location = new System.Drawing.Point(279, 68);
            this.lblimportounitario.Name = "lblimportounitario";
            this.lblimportounitario.Size = new System.Drawing.Size(101, 16);
            this.lblimportounitario.TabIndex = 4;
            this.lblimportounitario.Text = "Importo Unitario";
            // 
            // tbimportounitario
            // 
            this.tbimportounitario.Location = new System.Drawing.Point(280, 87);
            this.tbimportounitario.Name = "tbimportounitario";
            this.tbimportounitario.Size = new System.Drawing.Size(100, 22);
            this.tbimportounitario.TabIndex = 5;
            // 
            // tbquantita
            // 
            this.tbquantita.Location = new System.Drawing.Point(409, 87);
            this.tbquantita.Name = "tbquantita";
            this.tbquantita.Size = new System.Drawing.Size(100, 22);
            this.tbquantita.TabIndex = 7;
            // 
            // lblquantita
            // 
            this.lblquantita.AutoSize = true;
            this.lblquantita.Location = new System.Drawing.Point(408, 68);
            this.lblquantita.Name = "lblquantita";
            this.lblquantita.Size = new System.Drawing.Size(56, 16);
            this.lblquantita.TabIndex = 6;
            this.lblquantita.Text = "Quantitá";
            // 
            // btninserimento
            // 
            this.btninserimento.Location = new System.Drawing.Point(189, 160);
            this.btninserimento.Name = "btninserimento";
            this.btninserimento.Size = new System.Drawing.Size(173, 71);
            this.btninserimento.TabIndex = 8;
            this.btninserimento.Text = "Inserisci";
            this.btninserimento.UseVisualStyleBackColor = true;
            this.btninserimento.Click += new System.EventHandler(this.btninserimento_Click);
            // 
            // frmFatture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 284);
            this.Controls.Add(this.btninserimento);
            this.Controls.Add(this.tbquantita);
            this.Controls.Add(this.lblquantita);
            this.Controls.Add(this.tbimportounitario);
            this.Controls.Add(this.lblimportounitario);
            this.Controls.Add(this.lbldtpData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblcmbFatture);
            this.Controls.Add(this.cmbFattura);
            this.Name = "frmFatture";
            this.Text = "Fatture";
            this.Load += new System.EventHandler(this.frmFatture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFattura;
        private System.Windows.Forms.Label lblcmbFatture;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbldtpData;
        private System.Windows.Forms.Label lblimportounitario;
        private System.Windows.Forms.TextBox tbimportounitario;
        private System.Windows.Forms.TextBox tbquantita;
        private System.Windows.Forms.Label lblquantita;
        private System.Windows.Forms.Button btninserimento;
    }
}

