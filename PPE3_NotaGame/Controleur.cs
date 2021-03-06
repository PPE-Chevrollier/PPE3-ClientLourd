﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPE3_NotaGame
{
    /// <summary>
    /// classe Controleur : classe statique de lien entre Modele et les vues
    /// </summary>
    public static class Controleur
    {
        #region propriétés
        private static Modele vmodele;
        #endregion

        #region accesseurs
        /// <summary>
        /// propriété Vmodele
        /// </summary>
        public static Modele Vmodele
        {
            get { return vmodele; }
            set { vmodele = value; }
        }
        #endregion

        #region methodes
        /// <summary>
        /// instanciation du modele
        /// </summary>
        public static void init()
        {
            Vmodele = new Modele();
        }

        /// <summary>
        /// permet le crud sur la table Constructeur
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_constructeur(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
             //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur " + vmodele.DT[1].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[1].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[1].Update(vmodele.DT[1]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDConstructeur formCRUD = new FormCRUDConstructeur();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.TbNom.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[1].Rows[indice][1].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[1].NewRow();
                            NouvLigne["NomC"] = formCRUD.TbNom.Text;
                            vmodele.DT[1].Rows.Add(NouvLigne);
                            vmodele.DA[1].Update(vmodele.DT[1]);
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[1].Rows[indice]["NomC"] = formCRUD.TbNom.Text;
                        vmodele.DA[1].Update(vmodele.DT[1]);
                    }
                   
                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table Support
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete </param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_support(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce support " + vmodele.DT[2].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[3].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[3].Update(vmodele.DT[3]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDSupport formCRUD = new FormCRUDSupport(c, indice);  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.TbNom.Clear();
                    formCRUD.NumAnnee.Value = 2016;
                    formCRUD.CbConstructeur.SelectedIndex = -1;
                    formCRUD.TbCaract.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.TbNom.Text = vmodele.DT[2].Rows[indice][1].ToString();
                    formCRUD.NumAnnee.Value = Convert.ToInt32(vmodele.DT[2].Rows[indice][3]);
                    formCRUD.TbCaract.Text = vmodele.DT[2].Rows[indice][2].ToString();
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.TbNom.Text != "" && formCRUD.CbConstructeur.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[3].NewRow();
                            NouvLigne["NomS"] = formCRUD.TbNom.Text;
                            NouvLigne["AnneeSortie"] = formCRUD.NumAnnee.Value;
                            if (formCRUD.TbCaract.Text != "") NouvLigne["caracteristiques"] = formCRUD.TbCaract.Text;
                            else NouvLigne["caracteristiques"] = Convert.DBNull;

                            // récupération de l'IDC de la table constructeur correspondant au nom du constructeur sélectionné dans la comboBox
                            NouvLigne["IdC"] = Convert.ToInt32(vmodele.DT[1].Rows[formCRUD.CbConstructeur.SelectedIndex][0]);

                            vmodele.DT[3].Rows.Add(NouvLigne);
                            vmodele.DA[3].Update(vmodele.DT[3]);
                        }
                        else
                        {
                            MessageBox.Show("Sélectionner un nom et un constructeur au minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[3].Rows[indice]["NomS"] = formCRUD.TbNom.Text;
                        vmodele.DT[3].Rows[indice]["AnneeSortie"] = formCRUD.NumAnnee.Value;
                        if (formCRUD.TbCaract.Text != "") vmodele.DT[3].Rows[indice]["caracteristiques"] = formCRUD.TbCaract.Text;
                        else vmodele.DT[3].Rows[indice]["caracteristiques"] = Convert.DBNull;
                        vmodele.DT[3].Rows[indice]["IdC"] = Convert.ToInt32(vmodele.DT[1].Rows[formCRUD.CbConstructeur.SelectedIndex][0]);
                        vmodele.DA[3].Update(vmodele.DT[3]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table User
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_user(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce user " + vmodele.DT[7].Rows[indice][2].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[8].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[8].Update(vmodele.DT[8]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDUser formCRUD = new FormCRUDUser(c, indice);  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.Tb_Email.Clear();
                    formCRUD.Tb_Pseudo.Clear();
                    formCRUD.Cb_Communaute.SelectedIndex = -1;
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.Tb_Email.Text = vmodele.DT[7].Rows[indice][1].ToString();
                    formCRUD.Tb_Pseudo.Text = vmodele.DT[7].Rows[indice][2].ToString();
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Tb_Email.Text != "" && formCRUD.Tb_Pseudo.Text != "" && formCRUD.Cb_Communaute.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[8].NewRow();
                            NouvLigne["EMAIL"] = formCRUD.Tb_Email.Text;
                            NouvLigne["PSEUDO"] = formCRUD.Tb_Pseudo.Text;
                            NouvLigne["IDCO"] = Convert.ToInt32(vmodele.DT[9].Rows[formCRUD.Cb_Communaute.SelectedIndex][0]);

                            vmodele.DT[8].Rows.Add(NouvLigne);
                            vmodele.DA[8].Update(vmodele.DT[8]);
                        }
                        else
                        {
                            MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[8].Rows[indice]["EMAIL"] = formCRUD.Tb_Email.Text;
                        vmodele.DT[8].Rows[indice]["PSEUDO"] = formCRUD.Tb_Pseudo.Text;
                        vmodele.DT[8].Rows[indice]["IDCO"] = Convert.ToInt32(vmodele.DT[9].Rows[formCRUD.Cb_Communaute.SelectedIndex][0]);
                        vmodele.DA[8].Update(vmodele.DT[8]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table JeuxVideos
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_jeuxvideos(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce jeuxvideos " + vmodele.DT[6].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[6].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[6].Update(vmodele.DT[6]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDJeuxvideos formCRUD = new FormCRUDJeuxvideos();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.Tb_NomJV.Clear();
                    formCRUD.Nud_AneeSortie.Value = 2016;
                    formCRUD.Nud_Classification.Value = 3;
                    formCRUD.Tb_Editeur.Clear();
                    formCRUD.Tb_Description.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.Tb_NomJV.Text = vmodele.DT[6].Rows[indice][1].ToString();
                    formCRUD.Nud_AneeSortie.Value = Convert.ToInt32(vmodele.DT[6].Rows[indice][2]);
                    formCRUD.Nud_Classification.Value = Convert.ToInt32(vmodele.DT[6].Rows[indice][3]);
                    formCRUD.Tb_Editeur.Text = vmodele.DT[6].Rows[indice][4].ToString();
                    formCRUD.Tb_Description.Text = vmodele.DT[6].Rows[indice][5].ToString();
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Tb_NomJV.Text != "" && formCRUD.Nud_AneeSortie.Value != 0 && formCRUD.Nud_Classification.Value != 0 && formCRUD.Tb_Editeur.Text != "" && formCRUD.Tb_Description.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[6].NewRow();
                            NouvLigne["NOMJV"] = formCRUD.Tb_NomJV.Text;
                            NouvLigne["ANNEESORTIE"] = formCRUD.Nud_AneeSortie.Value;
                            NouvLigne["CLASSIFICATION"] = formCRUD.Nud_Classification.Value;
                            NouvLigne["EDITEUR"] = formCRUD.Tb_Editeur.Text;
                            NouvLigne["DESCRIPTION"] = formCRUD.Tb_Description.Text;

                            vmodele.DT[6].Rows.Add(NouvLigne);
                            vmodele.DA[6].Update(vmodele.DT[6]);
                        }
                        else
                        {
                            MessageBox.Show("Rentrer un nom au minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[6].Rows[indice]["NOMJV"] = formCRUD.Tb_NomJV.Text;
                        vmodele.DT[6].Rows[indice]["ANNEESORTIE"] = formCRUD.Nud_AneeSortie.Value;
                        vmodele.DT[6].Rows[indice]["CLASSIFICATION"] = formCRUD.Nud_Classification.Value;
                        vmodele.DT[6].Rows[indice]["EDITEUR"] = formCRUD.Tb_Editeur.Text;
                        vmodele.DT[6].Rows[indice]["DESCRIPTION"] = formCRUD.Tb_Description.Text;

                        vmodele.DA[6].Update(vmodele.DT[6]);
                    }

                    // MessageBox.Show("OK : données enregistrées jeux");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table Compatible
        /// </summary>
        /// <param name="c">définit l'action : c:create, u update, d delete</param>
        /// <param name="indice">indice de l'élément sélectionné à modifier ou supprimer, -1 si ajout</param>
        public static void crud_compatible(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce lien ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[5].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[5].Update(vmodele.DT[5]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDCompatible formCRUD = new FormCRUDCompatible(c, indice);  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.Cb_JeuxVideos.SelectedIndex = -1;
                    formCRUD.Cb_Support.SelectedIndex = -1;
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Cb_JeuxVideos.SelectedIndex != -1 && formCRUD.Cb_Support.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[5].NewRow();

                            NouvLigne["IDJV"] = Convert.ToInt32(vmodele.DT[6].Rows[formCRUD.Cb_JeuxVideos.SelectedIndex][0]);
                            NouvLigne["IdS"] = Convert.ToInt32(vmodele.DT[3].Rows[formCRUD.Cb_Support.SelectedIndex][0]);

                            vmodele.DT[5].Rows.Add(NouvLigne);
                            vmodele.DA[5].Update(vmodele.DT[5]);
                        }
                        else
                        {
                            MessageBox.Show("Rentrer un nom au minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[5].Rows[indice]["IdJV"] = Convert.ToInt32(vmodele.DT[6].Rows[formCRUD.Cb_JeuxVideos.SelectedIndex][0]);
                        vmodele.DT[5].Rows[indice]["IdS"] = Convert.ToInt32(vmodele.DT[3].Rows[formCRUD.Cb_Support.SelectedIndex][0]);

                        vmodele.DA[5].Update(vmodele.DT[5]);
                    }

                    // MessageBox.Show("OK : données enregistrées jeux");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table communaute
        /// </summary>
        /// <param name="c"></param>
        /// <param name="indice"></param>
        public static void crud_communaute(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette communaute " + vmodele.DT[9].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[9].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[9].Update(vmodele.DT[9]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDCommunaute formCRUD = new FormCRUDCommunaute();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.Tb_Communaute.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.Tb_Communaute.Text = vmodele.DT[9].Rows[indice][1].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Tb_Communaute.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[9].NewRow();
                            NouvLigne["LIBELLE"] = formCRUD.Tb_Communaute.Text;
                            vmodele.DT[9].Rows.Add(NouvLigne);
                            vmodele.DA[9].Update(vmodele.DT[9]);
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[9].Rows[indice]["LIBELLE"] = formCRUD.Tb_Communaute.Text;
                        vmodele.DA[9].Update(vmodele.DT[9]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// permet le crud sur la table communaute
        /// </summary>
        /// <param name="c"></param>
        /// <param name="indice"></param>
        public static void crud_genre(Char c, int indice)
        {
            if (c == 'd') // cas de la suppression
            {
                //   DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce constructeur "+ vmodele.DTConstructeur.Rows[indice][1].ToString()+ " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce genre " + vmodele.DT[10].Rows[indice][1].ToString() + " ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[10].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[10].Update(vmodele.DT[10]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                // cas de l'ajout et modification
                FormCRUDGenre formCRUD = new FormCRUDGenre();  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    formCRUD.Tb_Genre.Clear();
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    formCRUD.Tb_Genre.Text = vmodele.DT[10].Rows[indice][1].ToString();

                }
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Tb_Genre.Text != "")
                        {
                            DataRow NouvLigne = vmodele.DT[10].NewRow();
                            NouvLigne["LIBELLE"] = formCRUD.Tb_Genre.Text;
                            vmodele.DT[10].Rows.Add(NouvLigne);
                            vmodele.DA[10].Update(vmodele.DT[10]);
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[10].Rows[indice]["LIBELLE"] = formCRUD.Tb_Genre.Text;
                        vmodele.DA[10].Update(vmodele.DT[10]);
                    }

                    // MessageBox.Show("OK : données enregistrées Constructeur");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }

        /// <summary>
        /// Premet le crud de la table correspondre
        /// </summary>
        /// <param name="c"></param>
        /// <param name="indice"></param>
        public static void crud_correspondre(Char c, int indice)
        {
            if (c == 'd')  // suppression
            {
                DialogResult rep = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce lien ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    // on supprime l’élément du DataTable
                    vmodele.DT[12].Rows[indice].Delete();		// suppression dans le DataTable
                    vmodele.DA[12].Update(vmodele.DT[12]);			// mise à jour du DataAdapter
                }
            }
            else
            {
                FormCRUDCorrespondre formCRUD = new FormCRUDCorrespondre(c, indice);  // création de la nouvelle forme
                if (c == 'c')  // mode ajout donc pas de valeur à passer à la nouvelle forme
                {
                    // à écrire : mettre les contrôles de formCRUD à vide
                    formCRUD.Cb_Genre.SelectedIndex = -1;
                    formCRUD.Cb_JeuxVideos.SelectedIndex = -1;
                }

                if (c == 'u')   // mode update donc on récupère les champs
                {
                    // on remplit les zones par les valeurs du dataGridView correspondantes
                    // mise à jour de la comboBox faite avec le nom du constructeur dans le Load de la formCRUD
                }

            eti:
                // on affiche la nouvelle form
                formCRUD.ShowDialog();

                // si l’utilisateur clique sur OK
                if (formCRUD.DialogResult == DialogResult.OK)
                {
                    if (c == 'c') // ajout
                    {
                        // on crée une nouvelle ligne dans le dataView
                        if (formCRUD.Cb_Genre.SelectedIndex != -1 && formCRUD.Cb_JeuxVideos.SelectedIndex != -1)
                        {
                            DataRow NouvLigne = vmodele.DT[12].NewRow();

                            NouvLigne["IDGENRE"] = Convert.ToInt32(vmodele.DT[10].Rows[formCRUD.Cb_Genre.SelectedIndex][0]);
                            NouvLigne["IDJV"] = Convert.ToInt32(vmodele.DT[6].Rows[formCRUD.Cb_JeuxVideos.SelectedIndex][0]);

                            vmodele.DT[12].Rows.Add(NouvLigne);
                            vmodele.DA[12].Update(vmodele.DT[12]);
                        }
                        else
                        {
                            MessageBox.Show("Rentrer un nom au minimum", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // ne pas fermer la form : revenir avant le bouton OK
                            goto eti;
                        }
                    }

                    if (c == 'u')  // modif
                    {
                        // on met à jour le dataTable avec les nouvelles valeurs
                        vmodele.DT[12].Rows[indice]["IDGENRE"] = Convert.ToInt32(vmodele.DT[10].Rows[formCRUD.Cb_Genre.SelectedIndex][0]);
                        vmodele.DT[12].Rows[indice]["IDJV"] = Convert.ToInt32(vmodele.DT[6].Rows[formCRUD.Cb_JeuxVideos.SelectedIndex][0]);

                        vmodele.DA[12].Update(vmodele.DT[12]);
                    }

                    // MessageBox.Show("OK : données enregistrées jeux");
                    formCRUD.Dispose();  // on ferme la form
                }
                else
                {
                    MessageBox.Show("Annulation : aucune donnée enregistrée");
                    formCRUD.Dispose();
                }
            }
        }
        #endregion

    }
}
