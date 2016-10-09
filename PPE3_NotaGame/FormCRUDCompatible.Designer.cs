using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDCompatible
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lb_Support = new System.Windows.Forms.Label();
            this.lb_JeuxVideos = new System.Windows.Forms.Label();
            this.cb_JeuxVideos = new System.Windows.Forms.ComboBox();
            this.cb_Support = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(179, 195);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(27, 195);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lb_Support
            // 
            this.lb_Support.AutoSize = true;
            this.lb_Support.Location = new System.Drawing.Point(24, 135);
            this.lb_Support.Name = "lb_Support";
            this.lb_Support.Size = new System.Drawing.Size(44, 13);
            this.lb_Support.TabIndex = 14;
            this.lb_Support.Text = "Support";
            // 
            // lb_JeuxVideos
            // 
            this.lb_JeuxVideos.AutoSize = true;
            this.lb_JeuxVideos.Location = new System.Drawing.Point(24, 76);
            this.lb_JeuxVideos.Name = "lb_JeuxVideos";
            this.lb_JeuxVideos.Size = new System.Drawing.Size(58, 13);
            this.lb_JeuxVideos.TabIndex = 15;
            this.lb_JeuxVideos.Text = "Jeux video";
            // 
            // cb_JeuxVideos
            // 
            this.cb_JeuxVideos.FormattingEnabled = true;
            this.cb_JeuxVideos.Location = new System.Drawing.Point(127, 67);
            this.cb_JeuxVideos.Name = "cb_JeuxVideos";
            this.cb_JeuxVideos.Size = new System.Drawing.Size(121, 21);
            this.cb_JeuxVideos.TabIndex = 16;
            // 
            // cb_Support
            // 
            this.cb_Support.FormattingEnabled = true;
            this.cb_Support.Location = new System.Drawing.Point(127, 135);
            this.cb_Support.Name = "cb_Support";
            this.cb_Support.Size = new System.Drawing.Size(121, 21);
            this.cb_Support.TabIndex = 17;
            // 
            // FormCRUDCompatible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_Support);
            this.Controls.Add(this.cb_JeuxVideos);
            this.Controls.Add(this.lb_JeuxVideos);
            this.Controls.Add(this.lb_Support);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Name = "FormCRUDCompatible";
            this.Text = "FormCRUDCompatible";
            this.Load += new System.EventHandler(this.FormCRUDCompatible_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lb_Support;
        private System.Windows.Forms.Label lb_JeuxVideos;
        private System.Windows.Forms.ComboBox cb_JeuxVideos;
        private System.Windows.Forms.ComboBox cb_Support;

        public ComboBox Cb_JeuxVideos
        {
            get
            {
                return cb_JeuxVideos;
            }

            set
            {
                cb_JeuxVideos = value;
            }
        }

        public ComboBox Cb_Support
        {
            get
            {
                return cb_Support;
            }

            set
            {
                cb_Support = value;
            }
        }
    }
}