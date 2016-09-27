using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_NotaGame
{
    public partial class FormCRUDCompatible : Form
    {
        private char c = 'c';
        private int indice = -1;

        private void FormCRUDCompatible_Load(object sender, EventArgs e)
        {
            // chargement des noms des constructeurs dans la comboBox
            Cb_JeuxVideos.Items.Clear();
            Cb_Support.Items.Clear();

            Controleur.Vmodele.charger_donnees("jeuxvideos");
            Controleur.Vmodele.charger_donnees("support");

            if (Controleur.Vmodele.Chargement)
            {
                // parcours du DataTable des constructeurs pour remplir la comboBox
                for (int i = 0; i < Controleur.Vmodele.DT[4].Rows.Count; i++)
                {
                    Cb_JeuxVideos.Items.Add(Controleur.Vmodele.DT[4].Rows[i]["NomJV"].ToString());
                }

                for (int i = 0; i < Controleur.Vmodele.DT[2].Rows.Count; i++)
                {
                    Cb_Support.Items.Add(Controleur.Vmodele.DT[2].Rows[i]["NomS"].ToString());
                }

            }
            // si update : affichage du constructeur correspondant
            if (c == 'u') {
                Cb_JeuxVideos.SelectedItem = Controleur.Vmodele.DT[3].Rows[indice][0];
                Cb_Support.SelectedItem = Controleur.Vmodele.DT[3].Rows[indice][1];
            }
        }

        public FormCRUDCompatible(char c, int ind)
        {
            InitializeComponent();
            indice = ind;
            this.c = c;
        }

    }
}
