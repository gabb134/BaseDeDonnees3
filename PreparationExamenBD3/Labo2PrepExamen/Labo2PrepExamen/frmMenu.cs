using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2PrepExamen
{
    public partial class frmMenu : Form
    {
        frmEnregistrement frmEnregistrement = new frmEnregistrement();
        frmTabulaire frmtab = new frmTabulaire();
        frmPlusieursTables frmPlusieurs = new frmPlusieursTables();
        frmMaitreDetail frmDetail = new frmMaitreDetail();
        frmAffichageAvecFiltre frmFiltre = new frmAffichageAvecFiltre();



        public frmMenu()
        {
            InitializeComponent();
        }

        private void affchageEnregistrementParEnregistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnregistrement.ShowDialog();
            this.Show();
        }

        private void affichageTabulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtab.ShowDialog();
            this.Show();
        }

        private void affichageÀPartirDePlusieursYablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlusieurs.ShowDialog();
            this.Show();
        }

        private void affichageMaîtredétailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDetail.ShowDialog();
            this.Show();
        }

        private void affichageAvecFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFiltre.ShowDialog();
            this.Show();
        }
    }
}
