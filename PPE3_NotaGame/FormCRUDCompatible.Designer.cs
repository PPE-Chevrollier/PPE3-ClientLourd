using System.Windows.Forms;

namespace PPE3_NotaGame
{
    /// <summary>
    /// Class CRUD compatible
    /// </summary>
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
            this.Cb_JeuxVideos = new System.Windows.Forms.ComboBox();
            this.Cb_Support = new System.Windows.Forms.ComboBox();
            this.lb_JV = new System.Windows.Forms.Label();
            this.lb_S = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_JeuxVideos
            // 
            this.Cb_JeuxVideos.FormattingEnabled = true;
            this.Cb_JeuxVideos.Location = new System.Drawing.Point(121, 53);
            this.Cb_JeuxVideos.Name = "cb_JeuxVideos";
            this.Cb_JeuxVideos.Size = new System.Drawing.Size(121, 21);
            this.Cb_JeuxVideos.TabIndex = 0;
            // 
            // cb_Support
            // 
            this.Cb_Support.FormattingEnabled = true;
            this.Cb_Support.Location = new System.Drawing.Point(121, 126);
            this.Cb_Support.Name = "cb_Support";
            this.Cb_Support.Size = new System.Drawing.Size(121, 21);
            this.Cb_Support.TabIndex = 1;
            // 
            // lb_JV
            // 
            this.lb_JV.AutoSize = true;
            this.lb_JV.Location = new System.Drawing.Point(51, 56);
            this.lb_JV.Name = "lb_JV";
            this.lb_JV.Size = new System.Drawing.Size(64, 13);
            this.lb_JV.TabIndex = 2;
            this.lb_JV.Text = "Jeux vidéo :";
            // 
            // lb_S
            // 
            this.lb_S.AutoSize = true;
            this.lb_S.Location = new System.Drawing.Point(65, 129);
            this.lb_S.Name = "lb_S";
            this.lb_S.Size = new System.Drawing.Size(50, 13);
            this.lb_S.TabIndex = 3;
            this.lb_S.Text = "Support :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(179, 202);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(37, 202);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDCompatible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lb_S);
            this.Controls.Add(this.lb_JV);
            this.Controls.Add(this.Cb_Support);
            this.Controls.Add(this.Cb_JeuxVideos);
            this.Name = "FormCRUDCompatible";
            this.Text = "com";
            this.Load += new System.EventHandler(this.FormCRUDCompatible_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_JeuxVideos;
        private System.Windows.Forms.ComboBox cb_Support;
        private System.Windows.Forms.Label lb_JV;
        private System.Windows.Forms.Label lb_S;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;

        /// <summary>
        /// Accesseur de cb_jv
        /// </summary>
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

        /// <summary>
        /// accesseur cb support
        /// </summary>
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