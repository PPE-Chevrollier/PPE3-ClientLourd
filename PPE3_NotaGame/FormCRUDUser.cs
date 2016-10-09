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
    /// <summary>
    /// class CRUD users
    /// </summary>
    public partial class FormCRUDUser : Form
    {
        private char c = 'c';
        private int indice = -1;
        /// <summary>
        /// constructeur FormCRUDUser 
        /// </summary>
        public FormCRUDUser(char c, int ind)
        {
            InitializeComponent();
            indice = ind;
            this.c = c;
        }

        private void FormCRUDUser_Load(object sender, EventArgs e)
        {
            // chargement des noms des constructeurs dans la comboBox
            cb_Communaute.Items.Clear();

            Controleur.Vmodele.charger_donnees("communaute");

            if (Controleur.Vmodele.Chargement)
            {
                // parcours du DataTable des constructeurs pour remplir la comboBox
                for (int i = 0; i < Controleur.Vmodele.DT[9].Rows.Count; i++)
                {
                    cb_Communaute.Items.Add(Controleur.Vmodele.DT[9].Rows[i]["LIBELLE"].ToString());
                }
            }
            // si update : affichage de la communaute correspondante
            if (c == 'u')
            {
                cb_Communaute.SelectedItem = Controleur.Vmodele.DT[7].Rows[indice][3];
            }
        }
    }
}
