namespace Mari
{
    partial class frmMari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMari));
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblFigura = new System.Windows.Forms.Label();
            this.tbDato1 = new System.Windows.Forms.TextBox();
            this.tbDato2 = new System.Windows.Forms.TextBox();
            this.tbDato3 = new System.Windows.Forms.TextBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(12, 28);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 24);
            this.cmbFigura.TabIndex = 0;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(12, 9);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(45, 16);
            this.lblFigura.TabIndex = 1;
            this.lblFigura.Text = "Figura";
            // 
            // tbDato1
            // 
            this.tbDato1.Location = new System.Drawing.Point(173, 28);
            this.tbDato1.Name = "tbDato1";
            this.tbDato1.Size = new System.Drawing.Size(100, 22);
            this.tbDato1.TabIndex = 2;
            // 
            // tbDato2
            // 
            this.tbDato2.Location = new System.Drawing.Point(173, 72);
            this.tbDato2.Name = "tbDato2";
            this.tbDato2.Size = new System.Drawing.Size(100, 22);
            this.tbDato2.TabIndex = 3;
            // 
            // tbDato3
            // 
            this.tbDato3.Location = new System.Drawing.Point(173, 116);
            this.tbDato3.Name = "tbDato3";
            this.tbDato3.Size = new System.Drawing.Size(100, 22);
            this.tbDato3.TabIndex = 4;
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Location = new System.Drawing.Point(170, 9);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(43, 16);
            this.lblDato1.TabIndex = 5;
            this.lblDato1.Text = "Dato1";
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(170, 53);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(43, 16);
            this.lblDato2.TabIndex = 6;
            this.lblDato2.Text = "Dato2";
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Location = new System.Drawing.Point(170, 97);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(43, 16);
            this.lblDato3.TabIndex = 7;
            this.lblDato3.Text = "Dato3";
            // 
            // btnCalcola
            // 
            this.btnCalcola.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcola.Location = new System.Drawing.Point(97, 203);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(104, 45);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = false;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // frmMari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 260);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.tbDato3);
            this.Controls.Add(this.tbDato2);
            this.Controls.Add(this.tbDato1);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.cmbFigura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMari";
            this.Text = "Mari";
            this.Load += new System.EventHandler(this.frmMari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.TextBox tbDato1;
        private System.Windows.Forms.TextBox tbDato2;
        private System.Windows.Forms.TextBox tbDato3;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.Label lblDato3;
        private System.Windows.Forms.Button btnCalcola;
    }
}

