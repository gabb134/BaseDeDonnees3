using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                                                         nomCompletetEmploye = unEmploye.empPrenom+" "+unEmploye.empNom

                                                     };
        }
    }
}
