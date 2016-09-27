using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDUser
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
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Pseudo = new System.Windows.Forms.Label();
            this.lb_Communaute = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Pseudo = new System.Windows.Forms.TextBox();
            this.tb_Communaute = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(38, 58);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(38, 13);
            this.lb_Email.TabIndex = 0;
            this.lb_Email.Text = "Email :";
            // 
            // lb_Pseudo
            // 
            this.lb_Pseudo.AutoSize = true;
            this.lb_Pseudo.Location = new System.Drawing.Point(38, 112);
            this.lb_Pseudo.Name = "lb_Pseudo";
            this.lb_Pseudo.Size = new System.Drawing.Size(49, 13);
            this.lb_Pseudo.TabIndex = 1;
            this.lb_Pseudo.Text = "Pseudo :";
            // 
            // lb_Communaute
            // 
            this.lb_Communaute.AutoSize = true;
            this.lb_Communaute.Location = new System.Drawing.Point(38, 163);
            this.lb_Communaute.Name = "lb_Communaute";
            this.lb_Communaute.Size = new System.Drawing.Size(78, 13);
            this.lb_Communaute.TabIndex = 2;
            this.lb_Communaute.Text = "Communauté : ";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(125, 58);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 3;
            // 
            // tb_Pseudo
            // 
            this.tb_Pseudo.Location = new System.Drawing.Point(122, 112);
            this.tb_Pseudo.Name = "tb_Pseudo";
            this.tb_Pseudo.Size = new System.Drawing.Size(100, 20);
            this.tb_Pseudo.TabIndex = 4;
            // 
            // tb_Communaute
            // 
            this.tb_Communaute.Location = new System.Drawing.Point(122, 163);
            this.tb_Communaute.Name = "tb_Communaute";
            this.tb_Communaute.Size = new System.Drawing.Size(100, 20);
            this.tb_Communaute.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(165, 210);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(23, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tb_Communaute);
            this.Controls.Add(this.tb_Pseudo);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Communaute);
            this.Controls.Add(this.lb_Pseudo);
            this.Controls.Add(this.lb_Email);
            this.Name = "FormCRUDUser";
            this.Text = "FormCRUDUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Pseudo;
        private System.Windows.Forms.Label lb_Communaute;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Pseudo;
        private System.Windows.Forms.TextBox tb_Communaute;
        private Button btnAnnuler;
        private Button btnOK;

        public TextBox Tb_Email
        {
            get
            {
                return tb_Email;
            }

            set
            {
                tb_Email = value;
            }
        }

        public TextBox Tb_Pseudo
        {
            get
            {
                return tb_Pseudo;
            }

            set
            {
                tb_Pseudo = value;
            }
        }

        public TextBox Tb_Communaute
        {
            get
            {
                return tb_Communaute;
            }

            set
            {
                tb_Communaute = value;
            }
        }
    }
}