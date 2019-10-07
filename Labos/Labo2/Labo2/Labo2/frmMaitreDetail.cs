using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2
{
    public partial class frmMaitreDetail : Form
    {
        public frmMaitreDetail()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmMaitreDetail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contratsEmployes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratsEmployesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contratsEmployes);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employe);

        }
    }
}
