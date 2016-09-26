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
    /// FormCRUDSupport : form permettant l'ajout/modification d'un support
    /// </summary>
    public partial class FormCRUDSupport : Form
    {
        private char c='c';
        private int indice = -1;
      
        /// <summary>
        /// constructeur FormCRUDSupport 
        /// </summary>
        /// <param name="action">c : en creation, u : en update</param>
        /// <param name="ind">indice du support sélectionné en cas d'update</param>
        public FormCRUDSupport(char action, int ind)
        {
            InitializeComponent();
            c = action;
            indice = ind;
            
        }

        /// <summary>
        /// Chargement de FormCRUD : remplissage de la comboBox des constructeurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCRUD_Load(object sender, EventArgs e)
        {
            // chargement des noms des constructeurs dans la comboBox
            cbConstructeur.Items.Clear();
            Controleur.Vmodele.charger_donnees("constructeur");
            if (Controleur.Vmodele.Chargement)
            {
                // parcours du DataTable des constructeurs pour remplir la comboBox
                for (int i = 0; i < Controleur.Vmodele.DT[1].Rows.Count; i++)
                {
                    cbConstructeur.Items.Add(Controleur.Vmodele.DT[1].Rows[i]["NomC"].ToString());
                }

            }
            // si update : affichage du constructeur correspondant
            if (c == 'u') CbConstructeur.SelectedItem = Controleur.Vmodele.DT[2].Rows[indice][4]; 
        }
    }
}
