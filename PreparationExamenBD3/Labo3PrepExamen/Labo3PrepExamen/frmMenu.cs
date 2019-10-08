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
    public partial class frmMenu : Form
    {

        frmMVC frmmvc = new frmMVC();
        frmChargementDynamique frmChargement = new frmChargementDynamique();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void modèleMVCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmvc.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChargement.ShowDialog();
            this.Show();
        }
    }
}
