using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo3PrepExamen
{
    public partial class frmMVC : Form
    {
        public frmMVC()
        {
            InitializeComponent();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmMVC_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employe);

        }

        private void btnModifierNom_Click(object sender, EventArgs e)
        {
            bDVoyagesMarreroDataSet.employe[0].empNom = txt.Text;
        }

        private void btnSuspendreLiaison_Click(object sender, EventArgs e)
        {
            employeBindingSource.SuspendBinding();
            this.btnSuspendreLiaison.Enabled = false;
            this.btnReprendreLiaison.Enabled = true;
        }

        private void btnReprendreLiaison_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResumeBinding();
            this.btnReprendreLiaison.Enabled = false;
            this.btnSuspendreLiaison.Enabled = true;
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            employeBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            employeBindingSource.MoveLast();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Position de l'employé "+ bDVoyagesMarreroDataSet.employe[employeBindingSource.Position].empNom+" est "+ employeBindingSource.Position);
        }

        private void btnQuantite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il y a "+employeBindingSource.Count+" employés");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeBindingSource.ResetCurrentItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeBindingSource.RemoveCurrent();
        }
    }
}
