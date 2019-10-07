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
    public partial class frmReservationVoyages : Form
    {
        //Le numéro du client qui va effectuer des réservations
        public String noClient;
        public frmReservationVoyages()
        {
            InitializeComponent();
        }

        private void voyageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voyageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void voyageBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.voyageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmReservationVoyages_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.infosVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.infosVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.infosVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.destinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.destinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.destinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.destinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.destinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.destinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.voyage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           this.voyageTableAdapter.Fill(this.bDVoyagesMarreroDataSet.voyage);
            reservationsVoyagesTableAdapter.Fill(bDVoyagesMarreroDataSet.reservationsVoyages, Convert.ToDecimal(noClient));
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //ExecuteScalar : recheche 1 seule donnée
            //ExecutenonQuery : Execute 1 commande, exemple: update, insert, delete

            // Ouvrir la connexion
            String maChaineDeConnexion = Labo4.Properties.Settings.Default.BDVoyagesMarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();




            SqlTransaction maTransaction = maConnexion.BeginTransaction();
            try
            {
                //Variable 
                string requeteContrat = "INSERT INTO contrat VALUES (@noContrat, @maintenant, 200.00, 1140.58, 200.00, 1, 1002, @noVoyage, @noClient); ";
                string requeteFaitLeVoyage = "INSERT INTO faitLeVoyage VALUES (@noContrat, @noClient);";
                string requeteMaxContrat = "SELECT MAX(conNo) FROM contrat";

       
  
                SqlCommand maCommande = new SqlCommand(requeteMaxContrat, maConnexion);
                maCommande.Transaction = maTransaction;

                int intNoContrat = Convert.ToInt32(maCommande.ExecuteScalar()) + 1;
                //MessageBox.Show(intNoContrat.ToString());
                int intVoyage = Convert.ToInt32(dgInfosVoyages.CurrentRow.Cells[0].Value);
                string strMaintenant = DateTime.Now.Date.ToString();


                // Ajout d'un paramètre SQL Server pour requetecontrat
                SqlParameter monParametreSQL1 = new SqlParameter("@noVoyage", intVoyage);
                SqlParameter monParametreSQL2 = new SqlParameter("@maintenant", strMaintenant);
                SqlParameter monParametreSQL3 = new SqlParameter("@noContrat", intNoContrat);
                SqlParameter monParametreSQL4 = new SqlParameter("@noClient", noClient);

                // Ajout d'un paramètre SQL Server pour requetefaitlevoyage 
                SqlParameter monParametreSQL5 = new SqlParameter("@noContrat", intNoContrat);
                SqlParameter monParametreSQL6 = new SqlParameter("@noClient", noClient);



                maCommande = new SqlCommand(requeteContrat, maConnexion);
                maCommande.Transaction = maTransaction;
                //Pour requetecontrat
                maCommande.Parameters.Add(monParametreSQL1);
                maCommande.Parameters.Add(monParametreSQL2);
                maCommande.Parameters.Add(monParametreSQL3);
                maCommande.Parameters.Add(monParametreSQL4);
                
                maCommande.ExecuteNonQuery();
                //pour requetefaitlevoyage
                SqlCommand maCommande2 = new SqlCommand(requeteFaitLeVoyage, maConnexion);
                maCommande2.Transaction = maTransaction;

                maCommande2.Parameters.Add(monParametreSQL5);
                maCommande2.Parameters.Add(monParametreSQL6);

                maCommande2.ExecuteNonQuery();

                       maTransaction.Commit();
                MessageBox.Show("Transaction réussie");

                 //Pour mettre à jour la DataTable reservationsVoyages (qui contient les
                //réservations), tapez la commande suivante : 
                reservationsVoyagesTableAdapter.Fill(bDVoyagesMarreroDataSet.reservationsVoyages, Convert.ToDecimal(noClient));


      


            }
            catch
            {
                maTransaction.Rollback();
                MessageBox.Show("Transaction échouée");
            }
           

            maConnexion.Close();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Ouvrir la connexion
            String maChaineDeConnexion = Labo4.Properties.Settings.Default.BDVoyagesMarreroConnectionString;
            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            SqlTransaction maTransaction = maConnexion.BeginTransaction();
            try
            {
                string requeteFaitLeVoyage = "DELETE FROM faitLeVoyage WHERE conNo = @noContrat AND cliNo = @noClient";
                string requeteContrat = "DELETE FROM contrat WHERE conNo = @noContrat AND conNo NOT IN (SELECT conNo FROM faitLeVoyage)";



                int intNoContrat = Convert.ToInt32(dgReservationsVoyages.CurrentRow.Cells[0].Value);
                // MessageBox.Show(intNoContrat.ToString());


                // Ajout d'un paramètre SQL Server pour requetefaitlevoyage
                SqlParameter monParametreSQL1 = new SqlParameter("@noContrat", intNoContrat);
                SqlParameter monParametreSQL2 = new SqlParameter("@noClient", noClient);

                SqlCommand maCommande1 = new SqlCommand(requeteFaitLeVoyage, maConnexion);
                maCommande1.Transaction = maTransaction;
                maCommande1.Parameters.Add(monParametreSQL1);
                maCommande1.Parameters.Add(monParametreSQL2);

                maCommande1.ExecuteNonQuery();

                // Ajout d'un paramètre SQL Server pour requetecontrat
                SqlParameter monParametreSQL3 = new SqlParameter("@noContrat", intNoContrat);


                SqlCommand maCommande2 = new SqlCommand(requeteContrat, maConnexion);
                maCommande2.Transaction = maTransaction;
                maCommande2.Parameters.Add(monParametreSQL3);


                maCommande2.ExecuteNonQuery();


                maTransaction.Commit();
                MessageBox.Show("Transaction réussie");

                //Pour mettre à jour la DataTable reservationsVoyages (qui contient les
                //réservations), tapez la commande suivante : 
                reservationsVoyagesTableAdapter.Fill(bDVoyagesMarreroDataSet.reservationsVoyages, Convert.ToDecimal(noClient));



            }catch
            {
                maTransaction.Rollback();
                MessageBox.Show("Transaction échouée");
            }



            maConnexion.Close();
        }
    }
}
