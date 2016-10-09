using System.Windows.Forms;

namespace PPE3_NotaGame
{
    partial class FormCRUDCorrespondre
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
            this.lb_JeuxVideos = new System.Windows.Forms.Label();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.cb_JeuxVideos = new System.Windows.Forms.ComboBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_JeuxVideos
            // 
            this.lb_JeuxVideos.AutoSize = true;
            this.lb_JeuxVideos.Location = new System.Drawing.Point(24, 108);
            this.lb_JeuxVideos.Name = "lb_JeuxVideos";
            this.lb_JeuxVideos.Size = new System.Drawing.Size(63, 13);
            this.lb_JeuxVideos.TabIndex = 0;
            this.lb_JeuxVideos.Text = "Jeux videos";
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(24, 64);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(36, 13);
            this.lb_Genre.TabIndex = 1;
            this.lb_Genre.Text = "Genre";
            // 
            // cb_JeuxVideos
            // 
            this.cb_JeuxVideos.FormattingEnabled = true;
            this.cb_JeuxVideos.Location = new System.Drawing.Point(120, 105);
            this.cb_JeuxVideos.Name = "cb_JeuxVideos";
            this.cb_JeuxVideos.Size = new System.Drawing.Size(121, 21);
            this.cb_JeuxVideos.TabIndex = 2;
            // 
            // cb_Genre
            // 
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(120, 61);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(121, 21);
            this.cb_Genre.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(166, 198);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(14, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormCRUDCorrespondre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cb_Genre);
            this.Controls.Add(this.cb_JeuxVideos);
            this.Controls.Add(this.lb_Genre);
            this.Controls.Add(this.lb_JeuxVideos);
            this.Name = "FormCRUDCorrespondre";
            this.Text = "FormCRUDCorrespondre";
            this.Load += new System.EventHandler(this.FormCRUDCorrespondre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_JeuxVideos;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.ComboBox cb_JeuxVideos;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;

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

        public ComboBox Cb_Genre
        {
            get
            {
                return cb_Genre;
            }

            set
            {
                cb_Genre = value;
            }
        }
    }
}