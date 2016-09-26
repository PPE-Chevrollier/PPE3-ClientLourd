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
    /// FormGestion : form permettant la sélection d'une table de la BD et d'afficher les données correspondantes
    /// </summary>
    public partial class FormGestion : Form
    {
        private BindingSource bindingSource1;

        /// <summary>
        /// Constructeur FormGestion
        /// </summary>
        public FormGestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement FormGestion : chargement des noms des tables de la BD dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestion_Load(object sender, EventArgs e)
        {
           
            dGvJeux.Visible = false;
            Controleur.Vmodele.charger_donnees("toutes");
         
            if (Controleur.Vmodele.Chargement)
            {
             //   MessageBox.Show("BD chargée dans DataTable  : " + Controleur.Vmodele.DT1.Rows.Count.ToString());
                 for (int i = 0; i < Controleur.Vmodele.DT[0].Rows.Count; i++)
                 {
                     cbTable.Items.Add(Controleur.Vmodele.DT[0].Rows[i][0].ToString());
                 }
            }
        }
    
        /// <summary>
        /// évènement SelectedIndexChanged : à la sélection d'une table, on charge les données de la BD correspondantes dans le dataGridView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTable.SelectedIndex != -1)
            {
                string table = cbTable.SelectedItem.ToString(); // récupération de la table sélectionnée
                Controleur.Vmodele.charger_donnees(table);      // chargement des données de la table sélectionné dans le DT correspondant
                if (Controleur.Vmodele.Chargement)
                {
                    // un DT par table
                    bindingSource1 = new BindingSource();
                    if (table == "constructeur")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                        dGvJeux.DataSource = bindingSource1;
                        dGvJeux.Columns["IDC"].HeaderText = "Identifiant";
                        dGvJeux.Columns["NOMC"].HeaderText = "Nom_Constructeur";
                    }
                    else if (table == "support")
                    {
                        bindingSource1.DataSource = Controleur.Vmodele.DT[2];
                        dGvJeux.DataSource = bindingSource1;
                        dGvJeux.Columns["IDS"].HeaderText = "Id Support";
                        dGvJeux.Columns["NOMC"].HeaderText = "Nom_Constructeur";
                        dGvJeux.Columns["NOMS"].HeaderText = "Nom_Support";
                        dGvJeux.Columns["CARACTERISTIQUES"].HeaderText = "Caractéristiques";
                        dGvJeux.Columns["ANNEESORTIE"].HeaderText = "Année_Sortie";
                       
                    }

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dGvJeux.Refresh();
                    dGvJeux.Visible = true;
                }
                else
                {
                    MessageBox.Show("Table non gérée encore", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dGvJeux.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selectionner une table dans la liste déroulante", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du menu contextuel et appel aux méthodes correspondantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuStrip_Click(object sender, EventArgs e)
        {
            string table = cbTable.SelectedItem.ToString();
            if (sender == ajouterToolStripMenuItem)
            {
                // appel de la méthode du controleur en mode create
              
                if (table == "constructeur") Controleur.crud_constructeur('c', -1);
                if (table == "support") Controleur.crud_support('c', -1);
            }
            else
            {
                // vérifier qu’une ligne est bien sélectionnée dans le dataGridView
                if (dGvJeux.SelectedRows.Count == 1)
                {
                    if (sender == modifierToolStripMenuItem)
                    {
                        // appel de la méthode du controleur en mode update et avec la valeur de CodeFilm du film en clé
                        //   Controleur.crud_film('u', Convert.ToInt32(dGvPersonne.Rows[dGvPersonne.SelectedRows[0].Index].Cells[0].Value));
                       
                        if (table == "constructeur") Controleur.crud_constructeur('u', Convert.ToInt32(dGvJeux.SelectedRows[0].Index));
                        if (table == "support") Controleur.crud_support('u', Convert.ToInt32(dGvJeux.SelectedRows[0].Index));
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        // appel de la méthode du controleur en mode update et avec la valeur de CodeFilm du film en clé
                        //   Controleur.crud_film('u', Convert.ToInt32(dGvPersonne.Rows[dGvPersonne.SelectedRows[0].Index].Cells[0].Value));
                       
                        if (table == "constructeur") Controleur.crud_constructeur('d', Convert.ToInt32(dGvJeux.SelectedRows[0].Index));
                        if (table == "support") Controleur.crud_support('d', Convert.ToInt32(dGvJeux.SelectedRows[0].Index));
                    }
                   
                }
                else
                {
                    MessageBox.Show("Sélectionner une ligne à modifier/supprimer");
                }
            }

            // mise à jour du dataGridView en affichage     
            // appel de la méthode pour recharger toutes les données dans le DataGridView en cas d'ajout
            cbTable_SelectedIndexChanged(sender, e); 
            bindingSource1.MoveLast();
            bindingSource1.MoveFirst();
            dGvJeux.Refresh();
        }
    }
}
