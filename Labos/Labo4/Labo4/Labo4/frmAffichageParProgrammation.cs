using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Labo4
{
    public partial class frmAffichageParProgrammation : Form
    {
        // Réseau rouge( Local 444/424) 424-SQL2017,5433
        // Réseau bleu (Maison)tcp:424sql.cgodin.qc.ca,5433
        
        //La châine de connexion pour se connecter à la base de données
        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDVoyagesMarrero;User ID=5B6Marrero;Password=Linuxmaster134";
        //Objet SQLConnexion pour établir une connecion à la BD
        SqlConnection maConnexion = new SqlConnection();
        //Objet DataSet dans lequel nous allons ajouter des DataTables
        DataSet monDataSet = new DataSet();

        public frmAffichageParProgrammation()
        {
            InitializeComponent();
        }

        private void btnAfficherEmployes_Click(object sender, EventArgs e)
        {
            maConnexion.ConnectionString = maChaineDeConnexion;
            string maRequeteSQL = "SELECT empPrenom, empNom from employe";
            SqlDataAdapter dataAdapterEmployes = new SqlDataAdapter(maRequeteSQL, maConnexion);

            //détruit dataTable prenomNomEmployes si elle existe déjà dans le Dataset
            if (monDataSet.Tables.Contains("prenomNomEmployes"))
            {
                monDataSet.Tables.Remove("prenomNomEmployes");
            }
            //Crée la DataTable prenomNomEmployes et la remplit
            dataAdapterEmployes.Fill(monDataSet, "prenomNomEmployes");

            if (monDataSet.Tables["prenomNomEmployes"].Rows.Count == 0)
            {
                MessageBox.Show("La table des employes est vide","Erreur");
            }
            else
            {
                //Vide la liste
                lstEmployes.Items.Clear();

                foreach(DataRow ligneEmploye in monDataSet.Tables["prenomNomEmployes"].Rows)
                {
                    string prenomNomEmploye = ligneEmploye["empPrenom"] + " " + ligneEmploye["empNom"];
                    lstEmployes.Items.Add(prenomNomEmploye);
                }
            }
        }

        private void lstEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {



            //Vérifiez si la DataTable prenomNomEmployes existe dans votre DataSet. Si
            //elle n’existe pas, affichez un message d’erreur
            if (monDataSet.Tables.Contains("prenomNomEmployes"))
            {
                int indiceSelection = lstEmployes.SelectedIndex;
                DataRow ligneEmploye = monDataSet.Tables["prenomNomEmployes"].Rows[indiceSelection];
                String prenomEmploye = ligneEmploye["empPrenom"].ToString();
                String nomEmploye = ligneEmploye["empNom"].ToString();

                // Créez la requête SQL qui sélectionne tous les numéros de contrat de
                //l’employé à partir de son nom et de son prénom. 
                string maRequeteSQL = "select conNo from employe e inner join contrat c on e.empNo = c.empNo where  empPrenom = '"+ prenomEmploye + "' and empNom ='"+ nomEmploye+"'";


                //Créez un DataAdapter nommé dataAdapterContratsEmploye pour qu’il
                //accepte votre requête SQL et votre connexion.
                SqlDataAdapter dataAdapterContratsEmploye = new SqlDataAdapter(maRequeteSQL, maConnexion);

                //Vérifiez si la DataTable contratsEmploye existe dans votre DataSet.Si
                //c’est le cas, la détruire. 
                if (monDataSet.Tables.Contains("contratsEmploye"))
                {
                    monDataSet.Tables.Remove("contratsEmploye");
                }

                //À l’aide de votre DataAdapter, créez la DataTable contratsEmploye
                //dans votre DataSet puis remplissez - la
                dataAdapterContratsEmploye.Fill(monDataSet, "contratsEmploye");


                //Placez les numéros de contrats dans la liste lstContrats sans oublier de
                //la vider au départ. S’il n’y a pas de contrats pour l’employé sélectionné,
                //vous devez mettre Aucun contrat dans la liste lstContrats(voir des
                //exemples d’exécution plus bas). 

                if (monDataSet.Tables["contratsEmploye"].Rows.Count == 0)
                {
                    lstContrats.Items.Clear();
                    lstContrats.Items.Add("Aucun contrat");
                }
                else
                {
                    lstContrats.Items.Clear();



                    foreach (DataRow lignesContrats in monDataSet.Tables["contratsEmploye"].Rows)
                    {
                        string strLstContrat = lignesContrats["conNo"].ToString();
                        lstContrats.Items.Add(strLstContrat);
                    }

                }


                   
            }
            else
            {
                MessageBox.Show("La table prenomNomEmployes n'est pas dans le DataSet","Erreur");
            }
        }

            
    }
}
