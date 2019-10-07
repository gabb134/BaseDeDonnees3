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
    public partial class frmMenu : Form
    {
        frmEnregistrement fEnr = new frmEnregistrement();
        frmTabulaire fTab = new frmTabulaire();
        frmPlusieursTables fPlusieurs = new frmPlusieursTables();
        frmMaitreDetail fMaitre = new frmMaitreDetail();
        frmAffichageAvecFiltre fAvecFiltre = new frmAffichageAvecFiltre();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void affichageEnregistrementParEnregistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fEnr.ShowDialog();
            this.Show();
        }

        private void affichageTabulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTab.ShowDialog();
            this.Show();
        }

        private void affichageÀPartirDePlusieursTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPlusieurs.ShowDialog();
            this.Show();
        }

        private void affichageMaîtredétailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMaitre.ShowDialog();
            this.Show();
        }

        private void affichageAvecFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAvecFiltre.ShowDialog();
            this.Show();
        }
    }
}
