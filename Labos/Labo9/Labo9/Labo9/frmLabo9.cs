using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Labo9
{
    public partial class frmLabo9 : Form
    {

        DataClasses1DataContext monDataContext = new DataClasses1DataContext();

        public frmLabo9()
        {
            InitializeComponent();
        }

        private void frmLabo9_Load(object sender, EventArgs e)
        {
            monDataContext.Log = new System.IO.StreamWriter("Linq-To-SQL.log");

            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }

        private void btnTousLesCliens_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }

        private void btnClientParVille_Click(object sender, EventArgs e)
        {
            string strVille = tbVille.Text;
            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             where unClient.cliVille.Equals(strVille)
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (clientBindingSource.Current != null)
            {
                contratBindingSource.DataSource = from unContrat in monDataContext.contrat
                                                  where unContrat.client == (client)clientBindingSource.Current
                                                  select unContrat;
            }

            /* une autre façon
            if (clientBindingSource.Current != null)
            {
                contratBindingSource.DataSource = ((client)clientBindingSource.Current).contrat;
            }
            /******************************************/
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            contratBindingSource.EndEdit();

            try
            {
                monDataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
            }
            catch (ChangeConflictException)
            {
                monDataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'enregistrement des données");
                btnTousLesCliens.PerformClick(); //permet de fair ele click sur ce button, afin de recharger la page
            }
            
        }

        private void btnRemplacerVille_Click(object sender, EventArgs e)
        {
            var requeteRemplacerVille = from unClient in monDataContext.client
                                        where unClient.cliVille.Trim() == tbVilleSource.Text.Trim()
                                        select unClient;

            foreach(var unClientVille in requeteRemplacerVille)
            {
                unClientVille.cliVille = tbVilleCible.Text.Trim();
            }
        }

        private void frmLabo9_FormClosed(object sender, FormClosedEventArgs e)
        {
            monDataContext.Log.Close();
        }
    }
}
