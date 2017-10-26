namespace WindowsFormsReise
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.listBoxReiseteilnehmer = new System.Windows.Forms.ListBox();
            this.comboBoxReise = new System.Windows.Forms.ComboBox();
            this.labelNeuerTeilnehmer = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelMaxTeilnehmer = new System.Windows.Forms.Label();
            this.labelMaxTeilnehmerNr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.Location = new System.Drawing.Point(136, 203);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(142, 105);
            this.buttonHinzufügen.TabIndex = 0;
            this.buttonHinzufügen.Text = "Hinzufügen";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.buttonHinzufügen_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(12, 342);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(266, 23);
            this.buttonLoeschen.TabIndex = 1;
            this.buttonLoeschen.Text = "Teilnehmer Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // listBoxReiseteilnehmer
            // 
            this.listBoxReiseteilnehmer.FormattingEnabled = true;
            this.listBoxReiseteilnehmer.Location = new System.Drawing.Point(12, 57);
            this.listBoxReiseteilnehmer.Name = "listBoxReiseteilnehmer";
            this.listBoxReiseteilnehmer.Size = new System.Drawing.Size(266, 95);
            this.listBoxReiseteilnehmer.TabIndex = 2;
            // 
            // comboBoxReise
            // 
            this.comboBoxReise.FormattingEnabled = true;
            this.comboBoxReise.Location = new System.Drawing.Point(12, 12);
            this.comboBoxReise.Name = "comboBoxReise";
            this.comboBoxReise.Size = new System.Drawing.Size(266, 21);
            this.comboBoxReise.TabIndex = 3;
            // 
            // labelNeuerTeilnehmer
            // 
            this.labelNeuerTeilnehmer.AutoSize = true;
            this.labelNeuerTeilnehmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeuerTeilnehmer.Location = new System.Drawing.Point(8, 155);
            this.labelNeuerTeilnehmer.Name = "labelNeuerTeilnehmer";
            this.labelNeuerTeilnehmer.Size = new System.Drawing.Size(150, 20);
            this.labelNeuerTeilnehmer.TabIndex = 4;
            this.labelNeuerTeilnehmer.Text = "Neuer Teilnehmer";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 206);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(12, 245);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 20);
            this.textBoxVorname.TabIndex = 6;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(13, 288);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachname.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 190);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(10, 229);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(49, 13);
            this.labelVorname.TabIndex = 9;
            this.labelVorname.Text = "Vorname";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(15, 272);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(59, 13);
            this.labelNachname.TabIndex = 10;
            this.labelNachname.Text = "Nachname";
            // 
            // labelMaxTeilnehmer
            // 
            this.labelMaxTeilnehmer.AutoSize = true;
            this.labelMaxTeilnehmer.Location = new System.Drawing.Point(12, 38);
            this.labelMaxTeilnehmer.Name = "labelMaxTeilnehmer";
            this.labelMaxTeilnehmer.Size = new System.Drawing.Size(88, 13);
            this.labelMaxTeilnehmer.TabIndex = 11;
            this.labelMaxTeilnehmer.Text = "Max. Teilnehmer:";
            // 
            // labelMaxTeilnehmerNr
            // 
            this.labelMaxTeilnehmerNr.AutoSize = true;
            this.labelMaxTeilnehmerNr.Location = new System.Drawing.Point(107, 38);
            this.labelMaxTeilnehmerNr.Name = "labelMaxTeilnehmerNr";
            this.labelMaxTeilnehmerNr.Size = new System.Drawing.Size(13, 13);
            this.labelMaxTeilnehmerNr.TabIndex = 12;
            this.labelMaxTeilnehmerNr.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 377);
            this.Controls.Add(this.labelMaxTeilnehmerNr);
            this.Controls.Add(this.labelMaxTeilnehmer);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelNeuerTeilnehmer);
            this.Controls.Add(this.comboBoxReise);
            this.Controls.Add(this.listBoxReiseteilnehmer);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonHinzufügen);
            this.Name = "Form1";
            this.Text = "IrgendwasMitReise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.ListBox listBoxReiseteilnehmer;
        private System.Windows.Forms.ComboBox comboBoxReise;
        private System.Windows.Forms.Label labelNeuerTeilnehmer;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelMaxTeilnehmer;
        private System.Windows.Forms.Label labelMaxTeilnehmerNr;
    }
}

