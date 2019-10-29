using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;


namespace Labo10
{
    public partial class frmAjoutDeContratsVoyageurs : Form
    {
        private DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public frmAjoutDeContratsVoyageurs()
        {
            InitializeComponent();
        }

        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDate.Value > DateTime.Now)
            {
                errMessage.SetError(dtpDate, "La date ne doit pas être postérieure à la date  actuelle.");
                e.Cancel = true;
            }
            else
                errMessage.SetError(dtpDate, "");
        }

        private void nudAcompte_Validating(object sender, CancelEventArgs e)
        {
            if (nudAcompte.Value > nudMontant.Value)
            {
                errMessage.SetError(nudAcompte, "L'acompte ne doit pas dépasser le montant du contrat");
            }
            else
                errMessage.SetError(nudAcompte, "");
        }

        private void nudMontant_Validating(object sender, CancelEventArgs e)
        {
            if (nudMontant.Value < nudPaye.Value)
            {
                errMessage.SetError(nudMontant, "Le montant payé ne doit pas dépasser le montant du contrat");
            }
            else
                errMessage.SetError(nudMontant, "");
        }

        private void nudPaye_Validating(object sender, CancelEventArgs e)
        {
            if (nudPaye.Value < nudAcompte.Value)
            { 
                errMessage.SetError(nudPaye, "L'acompte ne doit pas dépasser le montant payé");
            }
            else
                errMessage.SetError(nudPaye, "");
        }

        private void frmAjoutDeContratsVoyageurs_Load(object sender, EventArgs e)
        {
            //chargement des employés
            noEtNomEmployeBindingSource.DataSource = from unEmploye in dataContext.employe
                                                     select new
                                                     {
                                                         noEmploye = unEmploye.empNo,
                                                         nomCompletEmploye = unEmploye.empPrenom+" "+unEmploye.empNom
                                                         
                                                     };

            

            //chargement des clients

            noEtNomClientBindingSource.DataSource = from unClient in dataContext.client
                                                    select new { noclient = unClient.cliNo,
                                                                  nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                                    };
            //chargement voyage
            noEtDestinationVoyageBindingSource.DataSource = from unVoyage in dataContext.voyage
                                                            let dateDepart = (DateTime)unVoyage.voyDateDepart
                                                            let dateArrivee = (DateTime)unVoyage.voyDateArrive
                                                            select new { noVoyage = unVoyage.voyNo,destinationVoyage = unVoyage.voyDestination.Trim()+"["+dateDepart.Date+"-->"+dateArrivee.Date+"]"};

            //chargemnet des clients et des voyageurs
            /* noEtNomClientBindingSource.DataSource = noEtNomClientBindingSource1.DataSource =
                 from unClient in dataContext.client
                 select new
                 {
                     noClient = unClient.cliNo,
                     nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                 };*/

            //avec objet noEtNomClient
            noEtNomClientBindingSource.DataSource = noEtNomClientBindingSource1.DataSource =
                from unClient in dataContext.client
                select new NoEtNomClient(unClient.cliNo, unClient.cliPrenom+" "+unClient.cliNom );

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren(ValidationConstraints.ImmediateChildren))
            {
                //Récupère tous les numéros de contrats à partir de la base de données
                var tousLesNosContrats = from contrat in dataContext.contrat
                                         select contrat.conNo;
                //Numéro du nouveau contrat
                decimal noContrat = tousLesNosContrats.Max() + 1;

                var nouveauContrat = new contrat
                {
                    conNo = noContrat,
                    conDate = dtpDate.Value.Date,
                    conAcompte = nudAcompte.Value,
                    conMontant = nudMontant.Value,
                    ConPaye = nudPaye.Value,
                    empNo = (decimal)cboEmploye.SelectedValue,
                    voyNo = (decimal)cboVoyage.SelectedValue,
                    cliNo = (decimal)cboClient.SelectedValue

                };

                //Insère le contrat dans le contexte
                dataContext.contrat.InsertOnSubmit(nouveauContrat);




                //Enregistre dans la base de données

                lstVoyageurs.SelectedItems.Cast<NoEtNomClient>().ToList().ForEach(c => dataContext.faitLeVoyage.InsertOnSubmit(new faitLeVoyage { conNo = noContrat, cliNo = c.noClient }));
                using (var porteeTransaction = new TransactionScope())
                {
                    try
                    {
                        dataContext.SubmitChanges();
                        MessageBox.Show("le contrat " + noContrat + " a été enregistré.", "Enregistrement du contrat");

                        porteeTransaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "impossible de modifier la base de données");
                    }
                }
                   
            }

          

        }

        private void lstVoyageurs_Validating(object sender, CancelEventArgs e)
        {
            if (lstVoyageurs.SelectedItems.Count != nudNbPlaces.Value)
            {
                errMessage.SetError(lstVoyageurs, $"Vous devez sélectionner {nudNbPlaces.Value} voyageurs(s)");
                e.Cancel = true;
            }
            else {
                //si un client dans lstVoyageurs dont la valeur est egal a noClient dans combobox --> true sinon false
                bool present = lstVoyageurs.SelectedItems.Cast<NoEtNomClient>().Any(c => c.noClient == (decimal)cboClient.SelectedValue);

                if (!present)
                {
                    errMessage.SetError(lstVoyageurs, "Le responsable doit faire partie du voyage");
                    e.Cancel = true;
                }
                else
                {
                    errMessage.SetError(lstVoyageurs, string.Empty);
                }
            }
        }
    }
}
