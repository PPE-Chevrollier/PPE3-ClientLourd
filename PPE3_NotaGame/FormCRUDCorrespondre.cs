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
    public partial class FormCRUDCorrespondre : Form
    {
        private char c = 'c';
        private int indice = -1;
        public FormCRUDCorrespondre(char action, int ind)
        {
            InitializeComponent();
            c = action;
            indice = ind;
        }

        private void FormCRUDCorrespondre_Load(object sender, EventArgs e)
        {
            // chargement des noms des constructeurs dans la comboBox
            cb_Genre.Items.Clear();
            Cb_JeuxVideos.Items.Clear();

            Controleur.Vmodele.charger_donnees("jeuxvideos");
            Controleur.Vmodele.charger_donnees("genre");

            if (Controleur.Vmodele.Chargement)
            {
                // parcours du DataTable des constructeurs pour remplir la comboBox
                for (int i = 0; i < Controleur.Vmodele.DT[10].Rows.Count; i++)
                {
                    cb_Genre.Items.Add(Controleur.Vmodele.DT[10].Rows[i]["LIBELLE"].ToString());
                }

                for (int i = 0; i < Controleur.Vmodele.DT[6].Rows.Count; i++)
                {
                    cb_JeuxVideos.Items.Add(Controleur.Vmodele.DT[6].Rows[i]["NOMJV"].ToString());
                }

            }
            // si update : affichage du constructeur correspondant
            if (c == 'u')
            {
                cb_Genre.SelectedItem = Controleur.Vmodele.DT[11].Rows[indice][0];
                cb_JeuxVideos.SelectedItem = Controleur.Vmodele.DT[11].Rows[indice][1];
            }
        }
    }
}
