using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo5
{
    public partial class frmListeDeValeursTab : Form
    {
        public frmListeDeValeursTab()
        {
            InitializeComponent();
        }

        private void contratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmListeDeValeursTab_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsClientsTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsClients);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsEmployes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsEmployesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsEmployes);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);


            contratTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(contratTableAdapter_RowUpdated);

        }
        private void contratTableAdapter_RowUpdated(Object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            if (e.RecordsAffected == 0)
            {
                String noContrat = e.Row["conNo"].ToString();
                MessageBox.Show("COnflit d'acces concurrentiel pour le contrat "+noContrat+". Cet enregistrement ne sera ps sauvegarde.","Conflit d'acces");
            }
        }

        private void dgContrats_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgContrats.Rows[e.RowIndex].ErrorText = "Le type de données de " + dgContrats.Columns[e.ColumnIndex].HeaderText + " n'est pas valide";
            e.Cancel = true;
        }

        private void dgContrats_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            string messageErreur = string.Empty;
            string strMontant = dgContrats["dgTxtMontant",e.RowIndex].Value.ToString();
            string strMontantPaye = dgContrats["dgTxtMontantPaye",e.RowIndex].Value.ToString();
            string strAccompte = dgContrats["dgTxtAcompte", e.RowIndex].Value.ToString();


            if (string.IsNullOrEmpty(strMontant) || string.IsNullOrEmpty(strMontantPaye) || string.IsNullOrEmpty(strAccompte))
            {
                messageErreur = "Aucun montant ne doit être vide";
            }
            else
            {
                double montantPaye = Convert.ToDouble(strMontantPaye);
                double montant = Convert.ToDouble(strMontant);
                double acompte = Convert.ToDouble(strAccompte);

                if (new List<double> {montantPaye,acompte,montant }.Any(d=> d < 0))
                {
                    messageErreur = "Aucun montant ne doit être plus petit que 0";
                }
                else if (acompte > montant)
                {
                    messageErreur = "l'acompte ne doit pas dépasser le montant du contrat";
                }
                else if (acompte > montantPaye)
                {
                    messageErreur = "L'acompte ne doit pas dépasser le montant payé";
                }
                else if (montant < montantPaye)
                {
                    messageErreur = "Le montant du contrat ne doit pas être inférieur au montant payé";
                }
            }
            dgContrats.Rows[e.RowIndex].ErrorText = messageErreur;
            if (messageErreur != string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void btnEnregistrerEnXML_Click(object sender, EventArgs e)
        {
            bDVoyagesMarreroDataSet.contrat.WriteXml("Contrats.xml");
            bDVoyagesMarreroDataSet.contrat.WriteXmlSchema("Contrats.xsd");

        }
    }
}
