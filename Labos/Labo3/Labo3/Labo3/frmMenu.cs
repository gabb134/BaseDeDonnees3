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
   
    public partial class frmMenu : Form
    {

        frmMVC fMVC = new frmMVC();
        frmChargementDynamique fCharge = new frmChargementDynamique();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void modèleMVCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMVC.ShowDialog();
            this.Show();
        }

        private void chargementDynamiqueDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCharge.ShowDialog();
            this.Show();
        }
    }
}
