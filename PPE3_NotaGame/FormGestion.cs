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
        #region propriete

        private BindingSource bindingSource1;

        #endregion

        #region methodes

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
                 for (int i = 1; i < Controleur.Vmodele.DT[0].Rows.Count; i++)
                 {
                     cbTable.Items.Add(Controleur.Vmodele.DT[0].Rows[i][0].ToString());
                 }
            }
        }

        /// <summary>
        /// Rend les colones non triables
        /// </summary>
        private void columnNotStoratble()
        {
            foreach (DataGridViewColumn column in dGvJeux.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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

                    switch (table)
                    {
                        case "constructeur":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[1];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDC"].HeaderText = "Identifiant";
                            dGvJeux.Columns["NOMC"].HeaderText = "Nom_Constructeur";
                            break;
                        case "support":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[2];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDS"].HeaderText = "Id_Support";
                            dGvJeux.Columns["NOMC"].HeaderText = "Nom_Constructeur";
                            dGvJeux.Columns["NOMS"].HeaderText = "Nom_Support";
                            dGvJeux.Columns["CARACTERISTIQUES"].HeaderText = "Caractéristiques";
                            dGvJeux.Columns["ANNEESORTIE"].HeaderText = "Année_Sortie";
                            break;
                        case "compatible":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[4];
                            dGvJeux.DataSource = bindingSource1;
                            //dGvJeux.Columns["IDJV"].HeaderText = "Id_jeuxvideo";
                            dGvJeux.Columns["NOMJV"].HeaderText = "Nom_jeuxvideo";
                            //dGvJeux.Columns["IDS"].HeaderText = "Id_Support";
                            dGvJeux.Columns["NOMS"].HeaderText = "Nom_Support";
                            break;
                        case "jeuxvideos":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[6];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDJV"].HeaderText = "Id_jeuxvideo";
                            dGvJeux.Columns["NOMJV"].HeaderText = "Nom_JeuxVideo";
                            dGvJeux.Columns["ANNEESORTIE"].HeaderText = "Annee_de_sortie";
                            dGvJeux.Columns["CLASSIFICATION"].HeaderText = "Classification";
                            dGvJeux.Columns["EDITEUR"].HeaderText = "Editeur";
                            dGvJeux.Columns["DESCRIPTION"].HeaderText = "Description";
                            break;
                        case "users":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[7];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDU"].HeaderText = "Id_users";
                            dGvJeux.Columns["EMAIL"].HeaderText = "Email";
                            dGvJeux.Columns["PSEUDO"].HeaderText = "Pseudo";
                            dGvJeux.Columns["LIBELLE"].HeaderText = "Communaute";
                            break;
                        case "communaute":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[9];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDCO"].HeaderText = "Id de comunaute";
                            dGvJeux.Columns["LIBELLE"].HeaderText = "Libelle";
                            break;
                        case "genre":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[10];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["IDGENRE"].HeaderText = "Id de genre";
                            dGvJeux.Columns["LIBELLE"].HeaderText = "Libelle";
                            break;
                        case "correspondre":
                            bindingSource1.DataSource = Controleur.Vmodele.DT[11];
                            dGvJeux.DataSource = bindingSource1;
                            dGvJeux.Columns["LIBELLE"].HeaderText = "Genre";
                            dGvJeux.Columns["NOMJV"].HeaderText = "Jeux video";
                            break;
                    }

                    // mise à jour du dataGridView via le bindingSource rempli par le DataTable
                    dGvJeux.Refresh();
                    columnNotStoratble();
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
                if (table == "users") Controleur.crud_user('c', -1);
                if (table == "jeuxvideos") Controleur.crud_jeuxvideos('c', -1);
                if (table == "compatible") Controleur.crud_compatible('c', -1);
                if (table == "communaute") Controleur.crud_communaute('c', -1);
                if (table == "genre") Controleur.crud_genre('c', -1);
                if (table == "correspondre") Controleur.crud_correspondre('c', -1);
            }
            else
            {
                // vérifier qu’une ligne est bien sélectionnée dans le dataGridView
                if (dGvJeux.SelectedRows.Count == 1)
                {
                    int indice = Convert.ToInt32(dGvJeux.SelectedRows[0].Index);

                    if (sender == modifierToolStripMenuItem)
                    {
                        // appel de la méthode du controleur en mode update et avec la valeur de CodeFilm du film en clé
                        //   Controleur.crud_film('u', Convert.ToInt32(dGvPersonne.Rows[dGvPersonne.SelectedRows[0].Index].Cells[0].Value));

                        if (table == "constructeur") Controleur.crud_constructeur('u', indice);
                        if (table == "support") Controleur.crud_support('u', indice);
                        if (table == "users") Controleur.crud_user('u', indice);
                        if (table == "jeuxvideos") Controleur.crud_jeuxvideos('u', indice);
                        if (table == "compatible") Controleur.crud_compatible('u', indice);
                        if (table == "communaute") Controleur.crud_communaute('u', indice);
                        if (table == "genre") Controleur.crud_genre('u', indice);
                        if (table == "correspondre") Controleur.crud_correspondre('u', indice);
                    }
                    if (sender == supprimerToolStripMenuItem)
                    {
                        // appel de la méthode du controleur en mode update et avec la valeur de CodeFilm du film en clé
                        //   Controleur.crud_film('u', Convert.ToInt32(dGvPersonne.Rows[dGvPersonne.SelectedRows[0].Index].Cells[0].Value));
                       
                        if (table == "constructeur") Controleur.crud_constructeur('d', indice);
                        if (table == "support") Controleur.crud_support('d', indice);
                        if (table == "users") Controleur.crud_user('d', indice);
                        if (table == "jeuxvideos") Controleur.crud_jeuxvideos('d', indice);
                        if (table == "compatible") Controleur.crud_compatible('d', indice);
                        if (table == "communaute") Controleur.crud_communaute('d', indice);
                        if (table == "genre") Controleur.crud_genre('d', indice);
                        if (table == "correspondre") Controleur.crud_correspondre('d', indice);
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

        #endregion
    }
}
