using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDJeuxvideos
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
            this.tb_NomJV = new System.Windows.Forms.TextBox();
            this.lb_NomJV = new System.Windows.Forms.Label();
            this.nud_AneeSortie = new System.Windows.Forms.NumericUpDown();
            this.lb_AneeSortie = new System.Windows.Forms.Label();
            this.nud_Classification = new System.Windows.Forms.NumericUpDown();
            this.lb_Classification = new System.Windows.Forms.Label();
            this.tb_Editeur = new System.Windows.Forms.TextBox();
            this.lb_Editeur = new System.Windows.Forms.Label();
            this.lb_Description = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AneeSortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Classification)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_NomJV
            // 
            this.tb_NomJV.Location = new System.Drawing.Point(168, 37);
            this.tb_NomJV.Name = "tb_NomJV";
            this.tb_NomJV.Size = new System.Drawing.Size(100, 20);
            this.tb_NomJV.TabIndex = 0;
            // 
            // lb_NomJV
            // 
            this.lb_NomJV.AutoSize = true;
            this.lb_NomJV.Location = new System.Drawing.Point(90, 40);
            this.lb_NomJV.Name = "lb_NomJV";
            this.lb_NomJV.Size = new System.Drawing.Size(72, 13);
            this.lb_NomJV.TabIndex = 1;
            this.lb_NomJV.Text = "Nom du jeux :";
            // 
            // nud_AneeSortie
            // 
            this.nud_AneeSortie.Location = new System.Drawing.Point(168, 75);
            this.nud_AneeSortie.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_AneeSortie.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nud_AneeSortie.Name = "nud_AneeSortie";
            this.nud_AneeSortie.Size = new System.Drawing.Size(100, 20);
            this.nud_AneeSortie.TabIndex = 2;
            this.nud_AneeSortie.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // lb_AneeSortie
            // 
            this.lb_AneeSortie.AutoSize = true;
            this.lb_AneeSortie.Location = new System.Drawing.Point(75, 77);
            this.lb_AneeSortie.Name = "lb_AneeSortie";
            this.lb_AneeSortie.Size = new System.Drawing.Size(87, 13);
            this.lb_AneeSortie.TabIndex = 3;
            this.lb_AneeSortie.Text = "Année de sortie :";
            // 
            // nud_Classification
            // 
            this.nud_Classification.Location = new System.Drawing.Point(168, 111);
            this.nud_Classification.Name = "nud_Classification";
            this.nud_Classification.Size = new System.Drawing.Size(100, 20);
            this.nud_Classification.TabIndex = 4;
            // 
            // lb_Classification
            // 
            this.lb_Classification.AutoSize = true;
            this.lb_Classification.Location = new System.Drawing.Point(88, 113);
            this.lb_Classification.Name = "lb_Classification";
            this.lb_Classification.Size = new System.Drawing.Size(74, 13);
            this.lb_Classification.TabIndex = 5;
            this.lb_Classification.Text = "Classification :";
            // 
            // tb_Editeur
            // 
            this.tb_Editeur.Location = new System.Drawing.Point(168, 148);
            this.tb_Editeur.Multiline = true;
            this.tb_Editeur.Name = "tb_Editeur";
            this.tb_Editeur.Size = new System.Drawing.Size(140, 53);
            this.tb_Editeur.TabIndex = 6;
            // 
            // lb_Editeur
            // 
            this.lb_Editeur.AutoSize = true;
            this.lb_Editeur.Location = new System.Drawing.Point(94, 151);
            this.lb_Editeur.Name = "lb_Editeur";
            this.lb_Editeur.Size = new System.Drawing.Size(46, 13);
            this.lb_Editeur.TabIndex = 7;
            this.lb_Editeur.Text = "Editeur :";
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.Location = new System.Drawing.Point(94, 228);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(66, 13);
            this.lb_Description.TabIndex = 9;
            this.lb_Description.Text = "Description :";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(168, 225);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(140, 53);
            this.tb_Description.TabIndex = 8;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(229, 304);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(87, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDJeuxvideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.lb_Editeur);
            this.Controls.Add(this.tb_Editeur);
            this.Controls.Add(this.lb_Classification);
            this.Controls.Add(this.nud_Classification);
            this.Controls.Add(this.lb_AneeSortie);
            this.Controls.Add(this.nud_AneeSortie);
            this.Controls.Add(this.lb_NomJV);
            this.Controls.Add(this.tb_NomJV);
            this.Name = "FormCRUDJeuxvideos";
            this.Text = "FormCRUDJeuxvideos";
            ((System.ComponentModel.ISupportInitialize)(this.nud_AneeSortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Classification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NomJV;
        private System.Windows.Forms.NumericUpDown nud_AneeSortie;
        private System.Windows.Forms.NumericUpDown nud_Classification;
        private System.Windows.Forms.TextBox tb_Editeur;
        private System.Windows.Forms.TextBox tb_Description;

        private System.Windows.Forms.Label lb_NomJV;
        private System.Windows.Forms.Label lb_AneeSortie;
        private System.Windows.Forms.Label lb_Classification;
        private System.Windows.Forms.Label lb_Editeur;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;

        public TextBox Tb_NomJV
        {
            get
            {
                return tb_NomJV;
            }

            set
            {
                tb_NomJV = value;
            }
        }

        public NumericUpDown Nud_AneeSortie
        {
            get
            {
                return nud_AneeSortie;
            }

            set
            {
                nud_AneeSortie = value;
            }
        }

        public NumericUpDown Nud_Classification
        {
            get
            {
                return nud_Classification;
            }

            set
            {
                nud_Classification = value;
            }
        }

        public TextBox Tb_Editeur
        {
            get
            {
                return tb_Editeur;
            }

            set
            {
                tb_Editeur = value;
            }
        }

        public TextBox Tb_Description
        {
            get
            {
                return tb_Description;
            }

            set
            {
                tb_Description = value;
            }
        }
    }
}