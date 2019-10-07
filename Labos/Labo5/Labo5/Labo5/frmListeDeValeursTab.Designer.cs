namespace Labo5
{
    partial class frmListeDeValeursTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDeValeursTab));
            this.bDVoyagesMarreroDataSet = new Labo5.BDVoyagesMarreroDataSet();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.contratTableAdapter();
            this.tableAdapterManager = new Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.contratBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contratBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgContrats = new System.Windows.Forms.DataGridView();
            this.nosEtNomsEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsEmployesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter();
            this.nosEtDestinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter();
            this.bDVoyagesMarreroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingNavigator)).BeginInit();
            this.contratBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDVoyagesMarreroDataSet
            // 
            this.bDVoyagesMarreroDataSet.DataSetName = "BDVoyagesMarreroDataSet";
            this.bDVoyagesMarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataMember = "contrat";
            this.contratBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // contratTableAdapter
            // 
            this.contratTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = this.contratTableAdapter;
            this.tableAdapterManager.employeTableAdapter = null;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.nosEtNomsEmployesTableAdapter = this.nosEtNomsEmployesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // contratBindingNavigator
            // 
            this.contratBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contratBindingNavigator.BindingSource = this.contratBindingSource;
            this.contratBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contratBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contratBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contratBindingNavigatorSaveItem});
            this.contratBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contratBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contratBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contratBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contratBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contratBindingNavigator.Name = "contratBindingNavigator";
            this.contratBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contratBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.contratBindingNavigator.TabIndex = 0;
            this.contratBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // contratBindingNavigatorSaveItem
            // 
            this.contratBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contratBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contratBindingNavigatorSaveItem.Image")));
            this.contratBindingNavigatorSaveItem.Name = "contratBindingNavigatorSaveItem";
            this.contratBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contratBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.contratBindingNavigatorSaveItem.Click += new System.EventHandler(this.contratBindingNavigatorSaveItem_Click);
            // 
            // dgContrats
            // 
            this.dgContrats.AutoGenerateColumns = false;
            this.dgContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContrats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgContrats.DataSource = this.contratBindingSource;
            this.dgContrats.Location = new System.Drawing.Point(12, 138);
            this.dgContrats.Name = "dgContrats";
            this.dgContrats.Size = new System.Drawing.Size(966, 220);
            this.dgContrats.TabIndex = 1;
            // 
            // nosEtNomsEmployesBindingSource
            // 
            this.nosEtNomsEmployesBindingSource.DataMember = "nosEtNomsEmployes";
            this.nosEtNomsEmployesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtNomsEmployesTableAdapter
            // 
            this.nosEtNomsEmployesTableAdapter.ClearBeforeFill = true;
            // 
            // nosEtDestinationsVoyagesBindingSource
            // 
            this.nosEtDestinationsVoyagesBindingSource.DataMember = "nosEtDestinationsVoyages";
            this.nosEtDestinationsVoyagesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtDestinationsVoyagesTableAdapter
            // 
            this.nosEtDestinationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // bDVoyagesMarreroDataSetBindingSource
            // 
            this.bDVoyagesMarreroDataSetBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            this.bDVoyagesMarreroDataSetBindingSource.Position = 0;
            // 
            // nosEtNomsClientsBindingSource
            // 
            this.nosEtNomsClientsBindingSource.DataMember = "nosEtNomsClients";
            this.nosEtNomsClientsBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtNomsClientsTableAdapter
            // 
            this.nosEtNomsClientsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "conNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "conDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "conDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "conAcompte";
            this.dataGridViewTextBoxColumn3.HeaderText = "conAcompte";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "conMontant";
            this.dataGridViewTextBoxColumn4.HeaderText = "conMontant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ConPaye";
            this.dataGridViewTextBoxColumn5.HeaderText = "ConPaye";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "conTypeOcc";
            this.dataGridViewTextBoxColumn6.HeaderText = "conTypeOcc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empNo";
            this.dataGridViewTextBoxColumn7.DataSource = this.nosEtNomsEmployesBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Nom complet";
            this.dataGridViewTextBoxColumn7.HeaderText = "empNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "empNo";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "voyNo";
            this.dataGridViewTextBoxColumn8.DataSource = this.nosEtDestinationsVoyagesBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Nom et Destination";
            this.dataGridViewTextBoxColumn8.HeaderText = "voyNo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "voyNo";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn9.DataSource = this.nosEtNomsClientsBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Nom et Prenom ";
            this.dataGridViewTextBoxColumn9.HeaderText = "cliNo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "cliNo";
            // 
            // frmListeDeValeursTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.dgContrats);
            this.Controls.Add(this.contratBindingNavigator);
            this.Name = "frmListeDeValeursTab";
            this.Text = "Liste de valeurs tabulaires";
            this.Load += new System.EventHandler(this.frmListeDeValeursTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingNavigator)).EndInit();
            this.contratBindingNavigator.ResumeLayout(false);
            this.contratBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDVoyagesMarreroDataSet bDVoyagesMarreroDataSet;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.contratTableAdapter contratTableAdapter;
        private BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contratBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contratBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgContrats;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter nosEtNomsEmployesTableAdapter;
        private System.Windows.Forms.BindingSource nosEtNomsEmployesBindingSource;
        private System.Windows.Forms.BindingSource nosEtDestinationsVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter nosEtDestinationsVoyagesTableAdapter;
        private System.Windows.Forms.BindingSource bDVoyagesMarreroDataSetBindingSource;
        private System.Windows.Forms.BindingSource nosEtNomsClientsBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter nosEtNomsClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
    }
}