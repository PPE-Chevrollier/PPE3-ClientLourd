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
    /// FormPrincipale : gestion du menu principale
    /// </summary>
    public partial class FormPrincipale : Form
    {

        /// <summary>
        /// constructeur FormPrincipale
        /// </summary>
        public FormPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form1_Load : initialisation du modèle, connexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Controleur.init();
            Controleur.Vmodele.seconnecter();
            if (Controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                MessageBox.Show("BD connectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Form1_FormClosed : déconnexion à la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controleur.Vmodele.Connopen)    // si connexion ouverte
            {
                Controleur.Vmodele.sedeconnecter();
                if ( !Controleur.Vmodele.Connopen)  // si connexion bien fermée
                {
                    MessageBox.Show("BD déconnectée", "Information BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// click sur item Quitter du menu : fermeture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// menu Gestion des données : ouverture FormGestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            FormGestion F = new FormGestion();
           // F.MdiParent = this;
            F.Show();
        }


    
    }
}
