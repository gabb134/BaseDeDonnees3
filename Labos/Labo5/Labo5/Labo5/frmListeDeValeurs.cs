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
    public partial class frmListeDeValeurs : Form
    {
        public frmListeDeValeurs()
        {
            InitializeComponent();
        }

        private void contratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDVoyagesMarreroDataSet);

        }

        private void frmListeDeValeurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsClients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsClientsTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsClients);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtDestinationsVoyages'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtDestinationsVoyagesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtDestinationsVoyages);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.nosEtNomsEmployes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.nosEtNomsEmployesTableAdapter.Fill(this.bDVoyagesMarreroDataSet.nosEtNomsEmployes);
            // TODO: cette ligne de code charge les données dans la table 'bDVoyagesMarreroDataSet.contrat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contratTableAdapter.Fill(this.bDVoyagesMarreroDataSet.contrat);

        }
    }
}
