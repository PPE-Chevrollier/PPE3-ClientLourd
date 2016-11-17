namespace PPE3_NotaGame
{
    partial class Form5Meilleurs
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
            this.rTB5Meilleurs = new System.Windows.Forms.RichTextBox();
            this.cBSupport = new System.Windows.Forms.ComboBox();
            this.cBGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exporterEnPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTB5Meilleurs
            // 
            this.rTB5Meilleurs.HideSelection = false;
            this.rTB5Meilleurs.Location = new System.Drawing.Point(71, 123);
            this.rTB5Meilleurs.Name = "rTB5Meilleurs";
            this.rTB5Meilleurs.ReadOnly = true;
            this.rTB5Meilleurs.Size = new System.Drawing.Size(320, 234);
            this.rTB5Meilleurs.TabIndex = 12;
            this.rTB5Meilleurs.Text = "";
            // 
            // cBSupport
            // 
            this.cBSupport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSupport.FormattingEnabled = true;
            this.cBSupport.Location = new System.Drawing.Point(331, 39);
            this.cBSupport.Name = "cBSupport";
            this.cBSupport.Size = new System.Drawing.Size(141, 21);
            this.cBSupport.TabIndex = 11;
            this.cBSupport.SelectedIndexChanged += new System.EventHandler(this.cBSupport_SelectedIndexChanged);
            // 
            // cBGenre
            // 
            this.cBGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGenre.FormattingEnabled = true;
            this.cBGenre.Location = new System.Drawing.Point(84, 39);
            this.cBGenre.Name = "cBGenre";
            this.cBGenre.Size = new System.Drawing.Size(132, 21);
            this.cBGenre.TabIndex = 10;
            this.cBGenre.SelectedIndexChanged += new System.EventHandler(this.cBGenre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Par support :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Par genre :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterEnPDFToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exporterEnPDFToolStripMenuItem
            // 
            this.exporterEnPDFToolStripMenuItem.Name = "exporterEnPDFToolStripMenuItem";
            this.exporterEnPDFToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exporterEnPDFToolStripMenuItem.Text = "Exporter en PDF";
            this.exporterEnPDFToolStripMenuItem.Click += new System.EventHandler(this.exporterEnPDFToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // Form5Meilleurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 393);
            this.Controls.Add(this.rTB5Meilleurs);
            this.Controls.Add(this.cBSupport);
            this.Controls.Add(this.cBGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5Meilleurs";
            this.Text = "Form5Meilleurs";
            this.Load += new System.EventHandler(this.Form5Meilleurs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTB5Meilleurs;
        private System.Windows.Forms.ComboBox cBSupport;
        private System.Windows.Forms.ComboBox cBGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exporterEnPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}