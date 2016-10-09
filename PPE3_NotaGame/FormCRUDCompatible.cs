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

        /// <summary>
        /// Crud compatible
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ind"></param>
        public FormCRUDCompatible(char action, int ind)
        {
            InitializeComponent();
            c = action;
            indice = ind;
        }

        private void FormCRUDCompatible_Load(object sender, EventArgs e)
        {
            // chargement des noms des constructeurs dans la comboBox
            cb_JeuxVideos.Items.Clear();
            cb_Support.Items.Clear();

            Controleur.Vmodele.charger_donnees("jeuxvideos");
            Controleur.Vmodele.charger_donnees("support");

            if (Controleur.Vmodele.Chargement)
            {
                // parcours du DataTable des constructeurs pour remplir la comboBox
                for (int i = 0; i < Controleur.Vmodele.DT[6].Rows.Count; i++)
                {
                    cb_JeuxVideos.Items.Add(Controleur.Vmodele.DT[6].Rows[i]["NomJV"].ToString());
                }

                for (int i = 0; i < Controleur.Vmodele.DT[3].Rows.Count; i++)
                {
                    cb_Support.Items.Add(Controleur.Vmodele.DT[3].Rows[i]["NomS"].ToString());
                }

            }
            // si update : affichage du constructeur correspondant
            if (c == 'u')
            {
                cb_JeuxVideos.SelectedItem = Controleur.Vmodele.DT[4].Rows[indice][0];
                cb_Support.SelectedItem = Controleur.Vmodele.DT[4].Rows[indice][1];
            }
        }
    }
}
