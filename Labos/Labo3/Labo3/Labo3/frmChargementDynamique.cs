using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo3
{
    public partial class frmChargementDynamique : Form
    {
        public frmChargementDynamique()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmChargementDynamique_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employe);

        }

        private void employeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeBindingSource_PositionChanged(object sender, EventArgs e)
        {

            int noEnregistrement = employeBindingSource.Position;
            int nbEnregistrement = employeBindingSource.Count;

         //   MessageBox.Show(" dehors No enregistrement : " + noEnregistrement + "\n nb enreegistrement :  " + nbEnregistrement);
            if (noEnregistrement >= 0 && noEnregistrement < nbEnregistrement-1  )
            {
                //MessageBox.Show(" dedans No enregistrement : " + noEnregistrement + "\n nb enreegistrement :  " + nbEnregistrement);

                dynamic enregistrementSelectionne = employeBindingSource.Current;
                if (!DBNull.Value.Equals(enregistrementSelectionne["empNo"]))
                {
                    decimal noEmployeSelectionne = enregistrementSelectionne["empNo"];
                    contratTableAdapter.ClearBeforeFill = true;
                    contratTableAdapter.Fill(bDVoyagesMarreroDataSet.contrat, noEmployeSelectionne);
                }
                else
                    MessageBox.Show("L'employé n'exixste pas!");

             
            


            }
        }
    }
}
