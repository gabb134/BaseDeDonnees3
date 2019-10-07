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
    public partial class frmAjouter : Form
    {
        public BDVoyagesMarreroDataSet.contratRow unContrat;
        public frmAjouter()
        {


          
            InitializeComponent();
        }

        private void frmAjouter_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsEmployes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsEmployesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsEmployes);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsClientsTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsClients);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            char point = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            var exprDonnee = new Regex("^[0-9]{1,4}(" + point + "[0-9]{2})?$");

            if (txtMontant.Text.Trim() == ""){
                errMessage.SetError(txtMontant," Le montant ne peut pas etre vide");
            }
            else if (!exprDonnee.IsMatch(txtMontant.Text))
            {
                errMessage.SetError(txtMontant, " le montant n'est pas dans un format valide");
            }
            else
            {
                errMessage.SetError(txtMontant, "");
                if (txtAcompte.Text.Trim()=="")
                {
                    errMessage.SetError(txtMontant, "L'acompte ne doit pas etre vide");

                }
                else if (!exprDonnee.IsMatch(txtAcompte.Text))
                {
                    errMessage.SetError(txtAcompte, "L'acompte n'est pas dans un format valide");
                }
                else
                {
                    decimal montant = Convert.ToDecimal(txtMontant.Text);
                    decimal acompte = Convert.ToDecimal(txtMontant.Text);

                    if (acompte > montant)
                    {
                        errMessage.SetError(txtAcompte,"L'acompte ne doit pas depasser le montant");

                    }
                    else
                    {
                        errMessage.SetError(txtAcompte, "");

                        unContrat.conMontant = montant;
                        unContrat.conAcompte = acompte;
                        unContrat.ConPaye = acompte;
                        unContrat.cliNo = Convert.ToDecimal(cboClients.SelectedValue.ToString());
                        unContrat.empNo = Convert.ToDecimal(cboVendeurs.SelectedValue.ToString());
                        unContrat.voyNo = Convert.ToDecimal(cboVoyages.SelectedValue.ToString());

                        this.Close();


                    }
                }
            }


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
