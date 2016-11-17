using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PPE3_NotaGame
{
    public partial class Form5Meilleurs : Form
    {
        public Form5Meilleurs()
        {
            InitializeComponent();
        }
        public void Afficher()
        {
            rTB5Meilleurs.Text = "Jeux \t / \tMoyenne des notes \n\n";
            if (cBGenre.SelectedIndex > 0 && cBSupport.SelectedIndex > 0)
            {
                Controleur.Vmodele.charger_donnees_meilleurs("WHERE g.LIBELLE LIKE \"" + cBGenre.SelectedItem.ToString() + "\" AND s.NOMS LIKE \"" + cBSupport.SelectedItem.ToString() + "\"");
            }
            else if (cBGenre.SelectedIndex > 0 && cBSupport.SelectedIndex < 1)
            {
                Controleur.Vmodele.charger_donnees_meilleurs("WHERE g.LIBELLE LIKE \"" + cBGenre.SelectedItem.ToString() + "\"");
            }
            else if (cBGenre.SelectedIndex < 1 && cBSupport.SelectedIndex > 0)
            {
                Controleur.Vmodele.charger_donnees_meilleurs("WHERE s.NOMS LIKE \"" + cBSupport.SelectedItem.ToString() + "\"");
            }
            else
            {
                Controleur.Vmodele.charger_donnees_meilleurs("");
            }
            for (int i = 0; i < Controleur.Vmodele.DT[13].Rows.Count; i++)
            {
                rTB5Meilleurs.Text += Controleur.Vmodele.DT[13].Rows[i][0].ToString() + "\t / \t" + Controleur.Vmodele.DT[13].Rows[i][1].ToString() + "\n";
            }
            rTB5Meilleurs.SelectAll();
            rTB5Meilleurs.SelectionTabs = new int[] { 75 };
            rTB5Meilleurs.AcceptsTab = true;
            rTB5Meilleurs.Select(0, 0);
        }
        public void MakePDF()
        {
            Document document = new Document();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            string name = "";
            for (int i = 0; i < DateTime.Today.ToShortDateString().Length; i++)
            {
                if (DateTime.Today.ToString().Substring(i, 1) != "/")
                {
                    name = name + DateTime.Today.ToShortDateString().Substring(i, 1);
                }
                else
                {
                    name = name + "-";
                }
            }
            //chgmtcommit
            name = "Report " + name;
            saveDialog.FileName = name;
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));
                document.Open();
                document.Add(new Phrase(this.cBGenre.Text.Trim() + "\n" + this.cBSupport.Text.Trim() + "\n\n\n"));
                document.Add(new Phrase(rTB5Meilleurs.Text.Trim()));
                document.Close();
                MessageBox.Show("Correctment exporté", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5Meilleurs_Load(object sender, EventArgs e)
        {
            Controleur.Vmodele.charger_donnees_meilleurs("listederou");
            cBGenre.Items.Add("--Tous les genres--");
            cBGenre.SelectedIndex = 0;
            cBSupport.Items.Add("--Tous les supports--");
            cBSupport.SelectedIndex = 0;
            for (int i = 0; i < Controleur.Vmodele.DT[14].Rows.Count; i++)
            {
                cBGenre.Items.Add(Controleur.Vmodele.DT[14].Rows[i][0].ToString());
            }
            for (int i = 0; i < Controleur.Vmodele.DT[15].Rows.Count; i++)
            {
                cBSupport.Items.Add(Controleur.Vmodele.DT[15].Rows[i][0].ToString());
            }
            Afficher();
        }
        private void cBGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Afficher();
        }
        private void cBSupport_SelectedIndexChanged(object sender, EventArgs e)
        {
            Afficher();
        }

        private void exporterEnPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePDF();
        }
    }
}
