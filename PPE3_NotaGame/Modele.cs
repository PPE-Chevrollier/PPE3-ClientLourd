using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PPE3_NotaGame
{
    /// <summary>
    /// Classe Modele gérant la connexion et gestion avec la BD "bd_ppe3_notagame"
    /// </summary>
     public class Modele 
    {
        #region propriétés

        private MySqlConnection myConnection;   // objet de connexion
        private bool connopen = false;          // test si la connexion est faite
        private bool errgrave = false;          // test si erreur lors de la connexion
        private bool chargement = false;        // test si le chargement d'une requête est fait

        /// <summary>
        /// les DataAdapter et DataTable seront gérés dans des collection avec pour chaque un indice correspondant :
        /// indice 0 : récupération des noms des tables
        /// indice 1 : Table Constructeur
        /// indice 2 : Table Support avec jointure pour récupérer tous les libellés
        /// indice 3 : Table Support
        /// indice 4 : Table compatible avec jointure pour récupérer tous les libellés
        /// indice 5 : Table compatible
        /// indice 6 : Table jeuxvideo
        /// indice 7 : Table users avec jointure pour récupérer tous les libellés
        /// indice 8 : Table users
        /// indice 9 : Table communaute
        /// indice 10 : Table genre
        /// indice 11 : Table correspondre avec jointure pour récupérer tous les libellés
        /// indice 12 : Table correspondre
        /// collection de DataAdapter
        /// </summary>
        private List<MySqlDataAdapter> dA = new List<MySqlDataAdapter>(); 
    
        // collection de DataTable récupérant les données correspond au DA associé
        private List<DataTable> dT = new List<DataTable>();

        #endregion

        #region accesseurs
         /// <summary>
         /// test si la connexion à la BD est ouverte
         /// </summary>
        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

         /// <summary>
         /// test si erreur lors de la connexion
         /// </summary>
        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }
     
         /// <summary>
        /// test si le chargement d'une requête est fait
         /// </summary>
        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }

        /// <summary>
        /// Accesseur de la collection des DataAdapter
        /// </summary>
        public List<MySqlDataAdapter> DA
        {
            get { return dA; }
            set { dA = value; }
        }
  
        /// <summary>
        /// Accesseur de la collection des DataTable
        /// </summary>
        public List<DataTable> DT
        {
            get { return dT; }
            set { dT = value; }
        }
        #endregion

        #region methodes

        /// <summary>
        /// Modele() : constructeur permettant l'ajout des DataAdpater et DataTable nécessaires (4 nécessaires pour l'existant actuel)
        /// indice 0 : récupération des noms des tables
        /// indice 1 : Table Constructeur
        /// indice 2 : Table Support avec jointure pour récupérer tous les libellés
        /// indice 3 : Table Support
        /// indice 4 : Table compatible avec jointure pour récupérer tous les libellés
        /// indice 5 : Table compatible
        /// indice 6 : Table jeuxvideo
        /// indice 7 : Table users avec jointure pour récupérer tous les libellés
        /// indice 8 : Table users
        /// indice 9 : Table communaute
        /// indice 10 : Table genre
        /// indice 11 : Table correspondre avec jointure pour récupérer tous les libellés
        /// indice 12 : Table correspondre
        /// </summary>
        public Modele() {

            for (int i = 0; i < 13; i++)
            {
                dA.Add(new MySqlDataAdapter());
                dT.Add(new DataTable());
            }
        }

        /// <summary>
        /// méthode seconnecter permettant la connexion à la BD : bd_ppe3_notagame
        /// </summary>
        public void seconnecter()
        {
            string myConnectionString = "Database=bd_notagame;Data Source=192.168.152.2;User Id=notagame;Password=Azerty123;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative 
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture BD NotaGame : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }
        }

        /// <summary>
        /// méthode sedeconnecter pour se déconnecter à la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture BD NotaGame : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// méthode générique privée pour charger le résultat d'une requête dans un dataTable via un dataAdapter
        /// Méthode appelée par charger_donnees(string table)
        /// </summary>
        /// <param name="requete">requete à charger</param>
        /// <param name="DT">dataTable</param>
        /// <param name="DA">dataAdapter</param>
        private void charger(string requete, DataTable DT, MySqlDataAdapter DA)
        {
            DA.SelectCommand = new MySqlCommand(requete, myConnection);

            // pour spécifier les instructions de mise à jour (insert, delete, update)
            MySqlCommandBuilder CB1 = new MySqlCommandBuilder(DA);
            try
            {
                DT.Clear();
                DA.Fill(DT);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable : " + err, "PBS table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }

        /// <summary>
        /// charge dans un DT les données de la table passée en paramètre
        /// </summary>
        /// <param name="table">nom de la table à requêter</param>
        public void charger_donnees(string table)
        {
            chargement = false;
            if (!connopen) return;		// pour vérifier que la BD est bien ouverte

            switch (table)
            {
                case "toutes":
                    charger("show tables;", dT[0], dA[0]);
                    break;
                case "constructeur":
                    charger("select * from constructeur;", dT[1], dA[1]);
                    break;
                case "support":
                    charger("select idS, nomS, caracteristiques, anneeSortie, nomC from support S inner join constructeur C on S.IDC = C.IDC order by idS;", dT[2], dA[2]);
                    charger("select * from support;", dT[3], dA[3]);
                    break;
                case "compatible":
                    charger("select NOMJV,NOMS from compatible AS C INNER JOIN jeuxvideos AS V ON C.IDJV=V.IDJV INNER JOIN support AS s ON C.IDS=s.IDS order by C.IDJV, C.IDS;", dT[4], dA[4]);
                    charger("select * from compatible order by idjv, ids;", dT[5], dA[5]);
                    break;
                case "jeuxvideos":
                    charger("select * from jeuxvideos;", dT[6], dA[6]);
                    break;
                case "users":
                    charger("select IDU,EMAIL, PSEUDO, LIBELLE from users AS u INNER JOIN communaute AS c ON u.IDCO=c.IDCO order by IDU;", dT[7], dA[7]);
                    charger("select * from users;", dT[8], dA[8]);
                    break;
                case "communaute":
                    charger("select * from communaute;", dT[9], dA[9]);
                    break;
                case "genre":
                    charger("select * from genre;", dT[10], dA[10]);
                    break;
                case "correspondre":
                    charger("select G.LIBELLE, J.NOMJV FROM correspondre C INNER JOIN genre G ON G.IDGENRE = C.IDGENRE INNER JOIN jeuxvideos J ON J.IDJV = C.IDJV ORDER BY C.IDGENRE, C.IDJV;", dT[11], dA[11]);
                    charger("select * from correspondre order by idgenre, idjv;", dT[12], dA[12]);
                    break;
            }
        }

        #endregion
    }
}
