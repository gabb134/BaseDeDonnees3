using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{
    public partial class frmConnexionClient : Form
    {
        frmReservationVoyages fVoyage = new frmReservationVoyages();
        public frmConnexionClient()
        {
            InitializeComponent();
        }

        private void frmConnexionClient_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            // Ouvrir la connexion

            String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDVoyagesMarrero;User ID=5B6Marrero;Password=Linuxmaster134";

            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String strPrenom = tbPrenom.Text.Trim();
            String strNom = tbNom.Text.Trim();

            //Créez un objet SqlCommand avec des paramètres SQL Serveur (voir démo du
           // cours 1 pour le paramétrage). La requête SQL doit sélectionner le no de client
            //dans la table client qui correspond au prénom et au nom de famille. 
            string maRequeteSql = "select cliNo from client where cliPrenom = '"+ strPrenom +"' and cliNom = '"+ strNom+"'";

            SqlCommand maCommande = new SqlCommand(maRequeteSql, maConnexion);

            //Exécutez la commande en utilisant la méthode ExecuteScalar() puis selon le
            //résultat retourné, affichez le bon message: si le no de client existe, vous
            //devez afficher « Connexion réussie » sinon vous devez afficher « Connexion
            //échouée »

            dynamic client = maCommande.ExecuteScalar();

            if (client == null)
                lblResultat.Text = "Connexcion echouée";
            else
            {
                lblResultat.Text = "Connexion réussie";
                fVoyage.noClient = client.ToString();
                this.Hide();
                fVoyage.ShowDialog();
                this.Show();
            }
             



           //Fermez la connexion (pour libérer les ressources).
            maConnexion.Close();
        }
    }
}
