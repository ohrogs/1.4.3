namespace FormVeicoli
{
    partial class frmVeicoli
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
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.cmbMotore = new System.Windows.Forms.ComboBox();
            this.dtImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.lblTarga = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblMotore = new System.Windows.Forms.Label();
            this.lblImmatricolazione = new System.Windows.Forms.Label();
            this.btnVeicolo = new System.Windows.Forms.Button();
            this.btnVeicoloCombustione = new System.Windows.Forms.Button();
            this.txtCombustibile = new System.Windows.Forms.TextBox();
            this.txtCilindrata = new System.Windows.Forms.TextBox();
            this.lblCombustibile = new System.Windows.Forms.Label();
            this.lblCilindrata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(33, 110);
            this.txtProprietario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(132, 22);
            this.txtProprietario.TabIndex = 1;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(33, 41);
            this.txtTarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(132, 22);
            this.txtTarga.TabIndex = 0;
            // 
            // cmbMotore
            // 
            this.cmbMotore.FormattingEnabled = true;
            this.cmbMotore.Items.AddRange(new object[] {
            "combustione",
            "elettrico"});
            this.cmbMotore.Location = new System.Drawing.Point(33, 181);
            this.cmbMotore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMotore.Name = "cmbMotore";
            this.cmbMotore.Size = new System.Drawing.Size(132, 24);
            this.cmbMotore.TabIndex = 2;
            // 
            // dtImmatricolazione
            // 
            this.dtImmatricolazione.Location = new System.Drawing.Point(33, 261);
            this.dtImmatricolazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtImmatricolazione.Name = "dtImmatricolazione";
            this.dtImmatricolazione.Size = new System.Drawing.Size(265, 22);
            this.dtImmatricolazione.TabIndex = 3;
            // 
            // lblTarga
            // 
            this.lblTarga.AutoSize = true;
            this.lblTarga.Location = new System.Drawing.Point(29, 21);
            this.lblTarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarga.Name = "lblTarga";
            this.lblTarga.Size = new System.Drawing.Size(44, 16);
            this.lblTarga.TabIndex = 5;
            this.lblTarga.Text = "Targa";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(29, 90);
            this.lblProprietario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(77, 16);
            this.lblProprietario.TabIndex = 6;
            this.lblProprietario.Text = "Proprietario";
            // 
            // lblMotore
            // 
            this.lblMotore.AutoSize = true;
            this.lblMotore.Location = new System.Drawing.Point(29, 161);
            this.lblMotore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotore.Name = "lblMotore";
            this.lblMotore.Size = new System.Drawing.Size(49, 16);
            this.lblMotore.TabIndex = 7;
            this.lblMotore.Text = "Motore";
            // 
            // lblImmatricolazione
            // 
            this.lblImmatricolazione.AutoSize = true;
            this.lblImmatricolazione.Location = new System.Drawing.Point(29, 241);
            this.lblImmatricolazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImmatricolazione.Name = "lblImmatricolazione";
            this.lblImmatricolazione.Size = new System.Drawing.Size(140, 16);
            this.lblImmatricolazione.TabIndex = 8;
            this.lblImmatricolazione.Text = "Data immatricolazione";
            // 
            // btnVeicolo
            // 
            this.btnVeicolo.Location = new System.Drawing.Point(589, 37);
            this.btnVeicolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVeicolo.Name = "btnVeicolo";
            this.btnVeicolo.Size = new System.Drawing.Size(157, 42);
            this.btnVeicolo.TabIndex = 4;
            this.btnVeicolo.Text = "Veicolo";
            this.btnVeicolo.UseVisualStyleBackColor = true;
            this.btnVeicolo.Click += new System.EventHandler(this.btnVeicolo_Click);
            // 
            // btnVeicoloCombustione
            // 
            this.btnVeicoloCombustione.Location = new System.Drawing.Point(589, 103);
            this.btnVeicoloCombustione.Name = "btnVeicoloCombustione";
            this.btnVeicoloCombustione.Size = new System.Drawing.Size(157, 37);
            this.btnVeicoloCombustione.TabIndex = 9;
            this.btnVeicoloCombustione.Text = "Veicolo Combustione";
            this.btnVeicoloCombustione.UseVisualStyleBackColor = true;
            this.btnVeicoloCombustione.Click += new System.EventHandler(this.btnVeicoloCombustione_Click);
            // 
            // txtCombustibile
            // 
            this.txtCombustibile.Location = new System.Drawing.Point(32, 315);
            this.txtCombustibile.Margin = new System.Windows.Forms.Padding(4);
            this.txtCombustibile.Name = "txtCombustibile";
            this.txtCombustibile.Size = new System.Drawing.Size(132, 22);
            this.txtCombustibile.TabIndex = 10;
            // 
            // txtCilindrata
            // 
            this.txtCilindrata.Location = new System.Drawing.Point(32, 360);
            this.txtCilindrata.Margin = new System.Windows.Forms.Padding(4);
            this.txtCilindrata.Name = "txtCilindrata";
            this.txtCilindrata.Size = new System.Drawing.Size(132, 22);
            this.txtCilindrata.TabIndex = 11;
            // 
            // lblCombustibile
            // 
            this.lblCombustibile.AutoSize = true;
            this.lblCombustibile.Location = new System.Drawing.Point(33, 291);
            this.lblCombustibile.Name = "lblCombustibile";
            this.lblCombustibile.Size = new System.Drawing.Size(85, 16);
            this.lblCombustibile.TabIndex = 12;
            this.lblCombustibile.Text = "Combustibile";
            this.lblCombustibile.Click += new System.EventHandler(this.lblCombustibile_Click);
            // 
            // lblCilindrata
            // 
            this.lblCilindrata.AutoSize = true;
            this.lblCilindrata.Location = new System.Drawing.Point(33, 341);
            this.lblCilindrata.Name = "lblCilindrata";
            this.lblCilindrata.Size = new System.Drawing.Size(63, 16);
            this.lblCilindrata.TabIndex = 13;
            this.lblCilindrata.Text = "Cilindrata";
            // 
            // frmVeicoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 487);
            this.Controls.Add(this.lblCilindrata);
            this.Controls.Add(this.lblCombustibile);
            this.Controls.Add(this.txtCilindrata);
            this.Controls.Add(this.txtCombustibile);
            this.Controls.Add(this.btnVeicoloCombustione);
            this.Controls.Add(this.btnVeicolo);
            this.Controls.Add(this.lblImmatricolazione);
            this.Controls.Add(this.lblMotore);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.lblTarga);
            this.Controls.Add(this.dtImmatricolazione);
            this.Controls.Add(this.cmbMotore);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.txtProprietario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVeicoli";
            this.Text = "Veicoli a moore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.ComboBox cmbMotore;
        private System.Windows.Forms.DateTimePicker dtImmatricolazione;
        private System.Windows.Forms.Label lblTarga;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblMotore;
        private System.Windows.Forms.Label lblImmatricolazione;
        private System.Windows.Forms.Button btnVeicolo;
        private System.Windows.Forms.Button btnVeicoloCombustione;
        private System.Windows.Forms.TextBox txtCombustibile;
        private System.Windows.Forms.TextBox txtCilindrata;
        private System.Windows.Forms.Label lblCombustibile;
        private System.Windows.Forms.Label lblCilindrata;
    }
}

