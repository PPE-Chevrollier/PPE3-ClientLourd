namespace PPE3_NotaGame
{
    partial class FormCRUDSupport
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.cbConstructeur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCaract = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(99, 39);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(242, 20);
            this.tbNom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Année de sortie :";
            // 
            // numAnnee
            // 
            this.numAnnee.Location = new System.Drawing.Point(130, 86);
            this.numAnnee.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(63, 20);
            this.numAnnee.TabIndex = 5;
            this.numAnnee.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // cbConstructeur
            // 
            this.cbConstructeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConstructeur.FormattingEnabled = true;
            this.cbConstructeur.Location = new System.Drawing.Point(116, 122);
            this.cbConstructeur.Name = "cbConstructeur";
            this.cbConstructeur.Size = new System.Drawing.Size(121, 21);
            this.cbConstructeur.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Constructeur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Caractéristiques :";
            // 
            // tbCaract
            // 
            this.tbCaract.Location = new System.Drawing.Point(116, 170);
            this.tbCaract.Multiline = true;
            this.tbCaract.Name = "tbCaract";
            this.tbCaract.Size = new System.Drawing.Size(268, 101);
            this.tbCaract.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(89, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(231, 293);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormCRUDSupport
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(413, 360);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbCaract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbConstructeur);
            this.Controls.Add(this.numAnnee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Name = "FormCRUDSupport";
            this.Text = "Ajout/Modification/Suppression de SUPPORT";
            this.Load += new System.EventHandler(this.FormCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;

        /// <summary>
        /// propriété TbNom de type TextBox : nom du support
        /// </summary>
        public System.Windows.Forms.TextBox TbNom
        {
            get { return tbNom; }
            set { tbNom = value; }
        }
        private System.Windows.Forms.Label label1;

     
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAnnee;

        /// <summary>
        /// propriété NumAnnee de type NumericUpDown : année du support
        /// </summary>
        public System.Windows.Forms.NumericUpDown NumAnnee
        {
            get { return numAnnee; }
            set { numAnnee = value; }
        }
        private System.Windows.Forms.ComboBox cbConstructeur;

        /// <summary>
        /// propriété CbConstructeur de type ComboBox : liste des constructeurs
        /// </summary>
        public System.Windows.Forms.ComboBox CbConstructeur
        {
            get { return cbConstructeur; }
            set { cbConstructeur = value; }
        }
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCaract;

        /// <summary>
        /// propriété TbCaract de type TextBox : caractéristiques du support
        /// </summary>
        public System.Windows.Forms.TextBox TbCaract
        {
            get { return tbCaract; }
            set { tbCaract = value; }
        }
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}