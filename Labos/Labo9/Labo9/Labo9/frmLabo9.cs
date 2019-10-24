using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo9
{
    public partial class frmLabo9 : Form
    {

        DataClasses1DataContext monDataContext = new DataClasses1DataContext();

        public frmLabo9()
        {
            InitializeComponent();
        }

        private void frmLabo9_Load(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }

        private void btnTousLesCliens_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }

        private void btnClientParVille_Click(object sender, EventArgs e)
        {
            string strVille = tbVille.Text;
            clientBindingSource.DataSource = from unClient in monDataContext.client
                                             where unClient.cliVille.Equals(strVille)
                                             let nomCompletClient = unClient.cliPrenom + " " + unClient.cliNom
                                             orderby nomCompletClient
                                             select unClient;
        }
    }
}
