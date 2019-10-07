using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Labo5
{
    public partial class frmListeDeValeurs : Form
    {
        public Regex eprMontant { get; }
        public frmListeDeValeurs()
        {
            InitializeComponent();

            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            eprMontant = new Regex("^[0-9]{1,4}("+point+"[0-9]{2})?$");
        }

        private void contratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmListeDeValeurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.faitLeVoyage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.faitLeVoyageTableAdapter.Fill(this.bDVoyagesMarreroDataSet.faitLeVoyage);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsClientsTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsClients);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsEmployes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsEmployesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsEmployes);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);

        }

       

        private void txtMontantPaye_Validating(object sender, CancelEventArgs e)
        {
            string messageErreur = string.Empty;
            if (!eprMontant.IsMatch(txtMontantPaye.Text))
            {
                messageErreur = "Cette donnée n'est pas dans un format valide";
                e.Cancel = true;
            }
            else
            {
                double montantPaye = Convert.ToDouble(txtMontantPaye.Text);
                double montant = Convert.ToDouble(txtMontant.Text);
                double acompte = Convert.ToDouble(txtAcompte.Text);

                if (montantPaye > montant)
                {
                    messageErreur = "Le montant paye depasse le montant du contrat";
                    e.Cancel = true;
                }
                else if (montantPaye < acompte)
                {
                    messageErreur = "Le montant paye est inferieur au montant de lacompte";
                    e.Cancel = true;
                }

            }
            errMessage.SetError(txtMontantPaye, messageErreur);
        }
        private void txtMontant_Validating(object sender, CancelEventArgs e)
        {

            string messageErreur = string.Empty;
            if (!eprMontant.IsMatch(txtMontant.Text))
            {
                messageErreur = "Cette donnée n'est pas dans un format valide";
                e.Cancel = true;
            }
            else
            {
                double montantPaye = Convert.ToDouble(txtMontantPaye.Text);
                double montant = Convert.ToDouble(txtMontant.Text);
                double acompte = Convert.ToDouble(txtAcompte.Text);

                if (montant < montantPaye)
                {
                    messageErreur = "Le montant du contrat est inferieur le montant paye";
                    e.Cancel = true;
                }
                else if (montant < acompte)
                {
                    messageErreur = "Le montant du contrat est inferieur au montant de lacompte";
                    e.Cancel = true;
                }

            }
            errMessage.SetError(txtMontant, messageErreur);


        }

        private void txtAcompte_Validating(object sender, CancelEventArgs e)
        {
            string messageErreur = string.Empty;
            if (!eprMontant.IsMatch(txtAcompte.Text))
            {
                messageErreur = "Cette donnée n'est pas dans un format valide";
                e.Cancel = true;
            }
            else
            {
                double montantPaye = Convert.ToDouble(txtMontantPaye.Text);
                double montant = Convert.ToDouble(txtMontant.Text);
                double acompte = Convert.ToDouble(txtAcompte.Text);

                if (acompte > montant)
                {
                    messageErreur = "Le montant de l'acombre dépasse le montant du contrat";
                    e.Cancel = true;
                }
                else if (acompte > montantPaye )
                {
                    messageErreur = "Le montant de l'acombre dépasse le montant payé";
                    e.Cancel = true;
                }

            }
            errMessage.SetError(txtAcompte, messageErreur);

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratBindingSource.EndEdit();


           /* try
            {
                tableAdapterManager.UpdateAll(bDVoyagesMarreroDataSet);
                MessageBox.Show("Les modifictions ont ete enregistre dans la base de donnees.","Enregistrement des donnees");
            }
            catch(DBConcurrencyException erreur)
            {
                String noContrat = erreur.Row["conNo"].ToString();
                MessageBox.Show("Conflit d'acces concurrentiel pour le contrat "+noContrat+ ".Aucun enregistrement possible.","Conflit d'acces");

            }*/

            this.faitLeVoyageBindingSource.EndEdit();
            this.faitLeVoyageTableAdapter.Update(this.bDVoyagesMarreroDataSet.faitLeVoyage);



            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);
            MessageBox.Show("Les modifications ont été enregistrées dans la base de données","Enregistrement des données",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            foreach(var row in faitLeVoyageBindingSource)
            {
                faitLeVoyageBindingSource.Remove(row);
            }
            contratBindingSource.RemoveCurrent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bDVoyagesMarreroDataSet.contrat.RejectChanges();
            contratBindingSource.ResetBindings(false);
            MessageBox.Show("Les modifications depuis le denier enregistrement ont été annulées ", "Annulation des modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {



            BDVoyagesMarreroDataSet.contratRow unContrat = bDVoyagesMarreroDataSet.contrat.NewcontratRow();

            decimal noContratMax = 0;
            foreach (BDVoyagesMarreroDataSet.contratRow uneLigne in bDVoyagesMarreroDataSet.contrat.Rows)
                if (uneLigne.conNo > noContratMax) noContratMax = uneLigne.conNo;

            unContrat.conNo = noContratMax + 1;

            unContrat.conDate = DateTime.Now.Date;
            unContrat.conTypeOcc = 1;
            unContrat.conMontant = -1;


            frmAjouter frAjout = new frmAjouter();

            frAjout.unContrat = unContrat;
            frAjout.ShowDialog();

            if (unContrat.conMontant != -1)
            {
                bDVoyagesMarreroDataSet.contrat.AddcontratRow(unContrat);

                contratBindingSource.MoveLast();
                MessageBox.Show("Le contrat "+unContrat.conNo.ToString() +" a ete ajoute","Ajout d'un contrat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }
        
    }
}
