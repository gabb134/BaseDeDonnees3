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
    public partial class frmAffichageAvecFiltre : Form
    {
        public frmAffichageAvecFiltre()
        {
            InitializeComponent();
        }

        private void employesAvecFiltreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employesAvecFiltreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employesAvecFiltreTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employesAvecFiltre, nomToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
