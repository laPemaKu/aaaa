namespace Vise_Formi
{
    partial class FormStudenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxStudenti = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStudenti
            // 
            this.lbxStudenti.FormattingEnabled = true;
            this.lbxStudenti.Location = new System.Drawing.Point(34, 77);
            this.lbxStudenti.Name = "lbxStudenti";
            this.lbxStudenti.Size = new System.Drawing.Size(339, 264);
            this.lbxStudenti.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(34, 38);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(141, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj novog studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Location = new System.Drawing.Point(407, 170);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(92, 23);
            this.btnObrisiStudenta.TabIndex = 2;
            this.btnObrisiStudenta.Text = "Obrisi studenta";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(34, 357);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(113, 23);
            this.btnObrisiSve.TabIndex = 3;
            this.btnObrisiSve.Text = "Obrisi sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            // 
            // FormStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnObrisiStudenta);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbxStudenti);
            this.Name = "FormStudenti";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudenti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnObrisiSve;
    }
}

