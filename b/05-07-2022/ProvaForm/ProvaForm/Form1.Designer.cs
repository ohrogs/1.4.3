namespace ProvaForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoNegozio = new System.Windows.Forms.TextBox();
            this.Abilita = new System.Windows.Forms.Button();
            this.rdAbilita = new System.Windows.Forms.RadioButton();
            this.rdDisabilita = new System.Windows.Forms.RadioButton();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.chkOrario = new System.Windows.Forms.CheckBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(171, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "esci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " Scegli la tua classe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Panettiere",
            "Garzone"});
            this.comboBox1.Location = new System.Drawing.Point(21, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confermi la scelta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TipoNegozio
            // 
            this.TipoNegozio.Enabled = false;
            this.TipoNegozio.Location = new System.Drawing.Point(181, 35);
            this.TipoNegozio.Name = "TipoNegozio";
            this.TipoNegozio.Size = new System.Drawing.Size(100, 22);
            this.TipoNegozio.TabIndex = 7;
            this.TipoNegozio.TextChanged += new System.EventHandler(this.TipoNegozio_TextChanged);
            // 
            // Abilita
            // 
            this.Abilita.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Abilita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Abilita.Location = new System.Drawing.Point(181, 75);
            this.Abilita.Name = "Abilita";
            this.Abilita.Size = new System.Drawing.Size(100, 24);
            this.Abilita.TabIndex = 8;
            this.Abilita.Text = "button2";
            this.Abilita.UseVisualStyleBackColor = false;
            this.Abilita.Click += new System.EventHandler(this.Abilita_Click);
            // 
            // rdAbilita
            // 
            this.rdAbilita.AutoSize = true;
            this.rdAbilita.Location = new System.Drawing.Point(19, 75);
            this.rdAbilita.Name = "rdAbilita";
            this.rdAbilita.Size = new System.Drawing.Size(102, 20);
            this.rdAbilita.TabIndex = 9;
            this.rdAbilita.TabStop = true;
            this.rdAbilita.Text = "Abilita nome";
            this.rdAbilita.UseVisualStyleBackColor = true;
            this.rdAbilita.CheckedChanged += new System.EventHandler(this.rdAbilita_CheckedChanged);
            // 
            // rdDisabilita
            // 
            this.rdDisabilita.AutoSize = true;
            this.rdDisabilita.Location = new System.Drawing.Point(19, 101);
            this.rdDisabilita.Name = "rdDisabilita";
            this.rdDisabilita.Size = new System.Drawing.Size(121, 20);
            this.rdDisabilita.TabIndex = 10;
            this.rdDisabilita.TabStop = true;
            this.rdDisabilita.Text = "Disabilita nome";
            this.rdDisabilita.UseVisualStyleBackColor = true;
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(19, 136);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(102, 20);
            this.chkData.TabIndex = 11;
            this.chkData.Text = "Mostra Data";
            this.chkData.UseVisualStyleBackColor = true;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // chkOrario
            // 
            this.chkOrario.AutoSize = true;
            this.chkOrario.Location = new System.Drawing.Point(19, 162);
            this.chkOrario.Name = "chkOrario";
            this.chkOrario.Size = new System.Drawing.Size(110, 20);
            this.chkOrario.TabIndex = 12;
            this.chkOrario.Text = "Mostra Orario";
            this.chkOrario.UseVisualStyleBackColor = true;
            this.chkOrario.CheckedChanged += new System.EventHandler(this.chkOrario_CheckedChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(348, 136);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 16);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(351, 162);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(29, 16);
            this.lblOra.TabIndex = 14;
            this.lblOra.Text = "Ora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 303);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.chkOrario);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.rdDisabilita);
            this.Controls.Add(this.rdAbilita);
            this.Controls.Add(this.Abilita);
            this.Controls.Add(this.TipoNegozio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Scelta carriera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TipoNegozio;
        private System.Windows.Forms.Button Abilita;
        private System.Windows.Forms.RadioButton rdAbilita;
        private System.Windows.Forms.RadioButton rdDisabilita;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.CheckBox chkOrario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOra;
    }
}

