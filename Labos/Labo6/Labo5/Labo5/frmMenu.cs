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
    public partial class frmMenu : Form
    {
        frmListeDeValeurs fListe = new frmListeDeValeurs();
        frmListeDeValeursTab fTab = new frmListeDeValeursTab();
        frmChampsCalcules fCalcule = new frmChampsCalcules();
     
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listesDeValeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 this.Hide();
             fListe.ShowDialog();
               this.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employe);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.employe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.employeTableAdapter.Fill(this.bDVoyagesMarreroDataSet.employe);

        }

        private void listesDeValeursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTab.ShowDialog();
            this.Show();
        }

        private void ajoutDeChampsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCalcule.ShowDialog();
            this.Show();
        }

        private void employeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void employeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void totalVentesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalVentesTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string format = totalVentesTextBox.Text;
            if (format == string.Empty)
            {
                format = "N/A";
            }
            else if (format != "N/A" && format.Substring(format.Length - 1, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }
            totalVentesTextBox.Text = format;
        }

        private void nbContratsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nbContratTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void plusPetiteVenteTextBox_TextChanged(object sender, EventArgs e)
        {
            string format = plusPetiteVenteTextBox.Text;
            if (format == string.Empty)
            {
                format = "N/A";
            }
            else if (format != "N/A" && format.Substring(format.Length - 1, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }
            plusPetiteVenteTextBox.Text = format;
        }

        private void plusGrandeVenteTextBox_TextChanged(object sender, EventArgs e)
        {
            string format = plusGrandeVenteTextBox.Text;
            if (format == string.Empty)
            {
                format = "N/A";
            }
            else if (format != "N/A" && format.Substring(format.Length - 1, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }
            plusGrandeVenteTextBox.Text = format;
        }

        private void moyenneVentesTextBox_TextChanged(object sender, EventArgs e)
        {
            string format = moyenneVentesTextBox.Text;
            if (format == string.Empty)
            {
                format = "N/A";
            }
            else if (format != "N/A" && format.Substring(format.Length - 1, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }
            moyenneVentesTextBox.Text = format;
        }

        private void commissionPercueTextBox_TextChanged(object sender, EventArgs e)
        {
            string format = commissionPercueTextBox.Text;
            if (format == string.Empty)
            {
                format = "N/A";
            }
            else if (format != "N/A" && format.Substring(format.Length - 1, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }
            commissionPercueTextBox.Text = format;
        }
    }
}
