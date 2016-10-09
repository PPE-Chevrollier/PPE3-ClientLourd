using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDCommunaute
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
            this.lb_Communaute = new System.Windows.Forms.Label();
            this.tb_Communaute = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Communaute
            // 
            this.lb_Communaute.AutoSize = true;
            this.lb_Communaute.Location = new System.Drawing.Point(28, 94);
            this.lb_Communaute.Name = "lb_Communaute";
            this.lb_Communaute.Size = new System.Drawing.Size(69, 13);
            this.lb_Communaute.TabIndex = 1;
            this.lb_Communaute.Text = "Communaute";
            // 
            // tb_Communaute
            // 
            this.tb_Communaute.Location = new System.Drawing.Point(129, 94);
            this.tb_Communaute.Name = "tb_Communaute";
            this.tb_Communaute.Size = new System.Drawing.Size(100, 20);
            this.tb_Communaute.TabIndex = 2;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(184, 168);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(32, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tb_Communaute);
            this.Controls.Add(this.lb_Communaute);
            this.Name = "FormCRUDCommunaute";
            this.Text = "FormCRUDCommunaute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Communaute;
        private System.Windows.Forms.TextBox tb_Communaute;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;

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