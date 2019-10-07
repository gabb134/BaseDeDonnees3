using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4
{

    public partial class frmMenu : Form
    {

        frmAffichageParProgrammation frAffichage = new frmAffichageParProgrammation();
        frmConnexionClient frClient = new frmConnexionClient();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void affichageParProgrammationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frAffichage.ShowDialog();
            this.Show();
        }

        private void réservationDeVoyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frClient.ShowDialog();
            this.Show();
        }
    }
}
