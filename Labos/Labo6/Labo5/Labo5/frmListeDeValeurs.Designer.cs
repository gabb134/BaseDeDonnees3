namespace Labo5
{
    partial class frmListeDeValeurs
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
            System.Windows.Forms.Label conNoLabel;
            System.Windows.Forms.Label conDateLabel;
            System.Windows.Forms.Label conAcompteLabel;
            System.Windows.Forms.Label conMontantLabel;
            System.Windows.Forms.Label conPayeLabel;
            System.Windows.Forms.Label conTypeOccLabel;
            System.Windows.Forms.Label empNoLabel;
            System.Windows.Forms.Label voyNoLabel;
            System.Windows.Forms.Label cliNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDeValeurs));
            this.bDVoyagesMarreroDataSet = new Labo5.BDVoyagesMarreroDataSet();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.contratTableAdapter();
            this.tableAdapterManager = new Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.nosEtNomsEmployesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter();
            this.contratBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contratBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtNoContrat = new System.Windows.Forms.TextBox();
            this.dtpDateContrat = new System.Windows.Forms.DateTimePicker();
            this.txtAcompte = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtMontantPaye = new System.Windows.Forms.TextBox();
            this.txtNbPlaces = new System.Windows.Forms.TextBox();
            this.cboEmployes = new System.Windows.Forms.ComboBox();
            this.nosEtNomsEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter();
            this.cboVoyages = new System.Windows.Forms.ComboBox();
            this.nosEtDestinationsVoyagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.faitLeVoyageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faitLeVoyageTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.faitLeVoyageTableAdapter();
            this.faitLeVoyageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            conNoLabel = new System.Windows.Forms.Label();
            conDateLabel = new System.Windows.Forms.Label();
            conAcompteLabel = new System.Windows.Forms.Label();
            conMontantLabel = new System.Windows.Forms.Label();
            conPayeLabel = new System.Windows.Forms.Label();
            conTypeOccLabel = new System.Windows.Forms.Label();
            empNoLabel = new System.Windows.Forms.Label();
            voyNoLabel = new System.Windows.Forms.Label();
            cliNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingNavigator)).BeginInit();
            this.contratBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faitLeVoyageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faitLeVoyageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // conNoLabel
            // 
            conNoLabel.AutoSize = true;
            conNoLabel.Location = new System.Drawing.Point(187, 91);
            conNoLabel.Name = "conNoLabel";
            conNoLabel.Size = new System.Drawing.Size(45, 13);
            conNoLabel.TabIndex = 1;
            conNoLabel.Text = "con No:";
            // 
            // conDateLabel
            // 
            conDateLabel.AutoSize = true;
            conDateLabel.Location = new System.Drawing.Point(187, 118);
            conDateLabel.Name = "conDateLabel";
            conDateLabel.Size = new System.Drawing.Size(54, 13);
            conDateLabel.TabIndex = 3;
            conDateLabel.Text = "con Date:";
            // 
            // conAcompteLabel
            // 
            conAcompteLabel.AutoSize = true;
            conAcompteLabel.Location = new System.Drawing.Point(187, 143);
            conAcompteLabel.Name = "conAcompteLabel";
            conAcompteLabel.Size = new System.Drawing.Size(52, 13);
            conAcompteLabel.TabIndex = 5;
            conAcompteLabel.Text = "Acompte:";
            // 
            // conMontantLabel
            // 
            conMontantLabel.AutoSize = true;
            conMontantLabel.Location = new System.Drawing.Point(187, 169);
            conMontantLabel.Name = "conMontantLabel";
            conMontantLabel.Size = new System.Drawing.Size(49, 13);
            conMontantLabel.TabIndex = 7;
            conMontantLabel.Text = "Montant:";
            // 
            // conPayeLabel
            // 
            conPayeLabel.AutoSize = true;
            conPayeLabel.Location = new System.Drawing.Point(187, 195);
            conPayeLabel.Name = "conPayeLabel";
            conPayeLabel.Size = new System.Drawing.Size(75, 13);
            conPayeLabel.TabIndex = 9;
            conPayeLabel.Text = "Montant paye:";
            // 
            // conTypeOccLabel
            // 
            conTypeOccLabel.AutoSize = true;
            conTypeOccLabel.Location = new System.Drawing.Point(187, 221);
            conTypeOccLabel.Name = "conTypeOccLabel";
            conTypeOccLabel.Size = new System.Drawing.Size(52, 13);
            conTypeOccLabel.TabIndex = 11;
            conTypeOccLabel.Text = "nb clients";
            // 
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Location = new System.Drawing.Point(187, 247);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new System.Drawing.Size(49, 13);
            empNoLabel.TabIndex = 13;
            empNoLabel.Text = "employé:";
            // 
            // voyNoLabel
            // 
            voyNoLabel.AutoSize = true;
            voyNoLabel.Location = new System.Drawing.Point(187, 273);
            voyNoLabel.Name = "voyNoLabel";
            voyNoLabel.Size = new System.Drawing.Size(46, 13);
            voyNoLabel.TabIndex = 15;
            voyNoLabel.Text = "Voyage:";
            // 
            // cliNoLabel
            // 
            cliNoLabel.AutoSize = true;
            cliNoLabel.Location = new System.Drawing.Point(187, 299);
            cliNoLabel.Name = "cliNoLabel";
            cliNoLabel.Size = new System.Drawing.Size(37, 13);
            cliNoLabel.TabIndex = 17;
            cliNoLabel.Text = "cli No:";
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
            // nosEtNomsEmployesTableAdapter
            // 
            this.nosEtNomsEmployesTableAdapter.ClearBeforeFill = true;
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
            this.contratBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.contratBindingNavigator.TabIndex = 0;
            this.contratBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // txtNoContrat
            // 
            this.txtNoContrat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conNo", true));
            this.txtNoContrat.Location = new System.Drawing.Point(271, 88);
            this.txtNoContrat.Name = "txtNoContrat";
            this.txtNoContrat.Size = new System.Drawing.Size(200, 20);
            this.txtNoContrat.TabIndex = 2;
            // 
            // dtpDateContrat
            // 
            this.dtpDateContrat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratBindingSource, "conDate", true));
            this.dtpDateContrat.Location = new System.Drawing.Point(271, 114);
            this.dtpDateContrat.Name = "dtpDateContrat";
            this.dtpDateContrat.Size = new System.Drawing.Size(200, 20);
            this.dtpDateContrat.TabIndex = 4;
            // 
            // txtAcompte
            // 
            this.txtAcompte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conAcompte", true));
            this.txtAcompte.Location = new System.Drawing.Point(271, 140);
            this.txtAcompte.Name = "txtAcompte";
            this.txtAcompte.Size = new System.Drawing.Size(200, 20);
            this.txtAcompte.TabIndex = 6;
            this.txtAcompte.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcompte_Validating);
            // 
            // txtMontant
            // 
            this.txtMontant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conMontant", true));
            this.txtMontant.Location = new System.Drawing.Point(271, 166);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(200, 20);
            this.txtMontant.TabIndex = 8;
            this.txtMontant.Validating += new System.ComponentModel.CancelEventHandler(this.txtMontant_Validating);
            // 
            // txtMontantPaye
            // 
            this.txtMontantPaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "ConPaye", true));
            this.txtMontantPaye.Location = new System.Drawing.Point(271, 192);
            this.txtMontantPaye.Name = "txtMontantPaye";
            this.txtMontantPaye.Size = new System.Drawing.Size(200, 20);
            this.txtMontantPaye.TabIndex = 10;
            this.txtMontantPaye.Validating += new System.ComponentModel.CancelEventHandler(this.txtMontantPaye_Validating);
            // 
            // txtNbPlaces
            // 
            this.txtNbPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conTypeOcc", true));
            this.txtNbPlaces.Location = new System.Drawing.Point(271, 218);
            this.txtNbPlaces.Name = "txtNbPlaces";
            this.txtNbPlaces.Size = new System.Drawing.Size(200, 20);
            this.txtNbPlaces.TabIndex = 12;
            // 
            // cboEmployes
            // 
            this.cboEmployes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contratBindingSource, "empNo", true));
            this.cboEmployes.DataSource = this.nosEtNomsEmployesBindingSource;
            this.cboEmployes.DisplayMember = "Nom complet";
            this.cboEmployes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployes.FormattingEnabled = true;
            this.cboEmployes.Location = new System.Drawing.Point(271, 243);
            this.cboEmployes.Name = "cboEmployes";
            this.cboEmployes.Size = new System.Drawing.Size(200, 21);
            this.cboEmployes.TabIndex = 19;
            this.cboEmployes.ValueMember = "empNo";
            // 
            // nosEtNomsEmployesBindingSource
            // 
            this.nosEtNomsEmployesBindingSource.DataMember = "nosEtNomsEmployes";
            this.nosEtNomsEmployesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
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
            // cboVoyages
            // 
            this.cboVoyages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contratBindingSource, "voyNo", true));
            this.cboVoyages.DataSource = this.nosEtDestinationsVoyagesBindingSource;
            this.cboVoyages.DisplayMember = "Nom et Destination";
            this.cboVoyages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoyages.FormattingEnabled = true;
            this.cboVoyages.Location = new System.Drawing.Point(271, 270);
            this.cboVoyages.Name = "cboVoyages";
            this.cboVoyages.Size = new System.Drawing.Size(200, 21);
            this.cboVoyages.TabIndex = 20;
            this.cboVoyages.ValueMember = "voyNo";
            // 
            // nosEtDestinationsVoyagesBindingSource1
            // 
            this.nosEtDestinationsVoyagesBindingSource1.DataMember = "nosEtDestinationsVoyages";
            this.nosEtDestinationsVoyagesBindingSource1.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // cboClients
            // 
            this.cboClients.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contratBindingSource, "cliNo", true));
            this.cboClients.DataSource = this.nosEtNomsClientsBindingSource;
            this.cboClients.DisplayMember = "Nom et Prenom ";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(271, 299);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(200, 21);
            this.cboClients.TabIndex = 21;
            this.cboClients.ValueMember = "cliNo";
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
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnFermer
            // 
            this.btnFermer.CausesValidation = false;
            this.btnFermer.Location = new System.Drawing.Point(148, 347);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 22;
            this.btnFermer.Text = "Quitter";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.CausesValidation = false;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(301, 347);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(122, 36);
            this.btnEnregistrer.TabIndex = 23;
            this.btnEnregistrer.Text = "Enregistrer les modification";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.CausesValidation = false;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(577, 347);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(122, 36);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "Supprimer le contrat";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.CausesValidation = false;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(429, 347);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(122, 36);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "Annuler la modification";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // faitLeVoyageBindingSource
            // 
            this.faitLeVoyageBindingSource.DataMember = "faitLeVoyage";
            this.faitLeVoyageBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // faitLeVoyageTableAdapter
            // 
            this.faitLeVoyageTableAdapter.ClearBeforeFill = true;
            // 
            // faitLeVoyageDataGridView
            // 
            this.faitLeVoyageDataGridView.AutoGenerateColumns = false;
            this.faitLeVoyageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faitLeVoyageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.faitLeVoyageDataGridView.DataSource = this.faitLeVoyageBindingSource;
            this.faitLeVoyageDataGridView.Location = new System.Drawing.Point(494, 88);
            this.faitLeVoyageDataGridView.Name = "faitLeVoyageDataGridView";
            this.faitLeVoyageDataGridView.Size = new System.Drawing.Size(244, 146);
            this.faitLeVoyageDataGridView.TabIndex = 25;
            this.faitLeVoyageDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "conNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "cliNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnAjouter
            // 
            this.btnAjouter.CausesValidation = false;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(714, 347);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(122, 36);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter un contrat";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmListeDeValeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.faitLeVoyageDataGridView);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.cboVoyages);
            this.Controls.Add(this.cboEmployes);
            this.Controls.Add(conNoLabel);
            this.Controls.Add(this.txtNoContrat);
            this.Controls.Add(conDateLabel);
            this.Controls.Add(this.dtpDateContrat);
            this.Controls.Add(conAcompteLabel);
            this.Controls.Add(this.txtAcompte);
            this.Controls.Add(conMontantLabel);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(conPayeLabel);
            this.Controls.Add(this.txtMontantPaye);
            this.Controls.Add(conTypeOccLabel);
            this.Controls.Add(this.txtNbPlaces);
            this.Controls.Add(empNoLabel);
            this.Controls.Add(voyNoLabel);
            this.Controls.Add(cliNoLabel);
            this.Controls.Add(this.contratBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmListeDeValeurs";
            this.Text = "frmListeDeValeurs";
            this.Load += new System.EventHandler(this.frmListeDeValeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingNavigator)).EndInit();
            this.contratBindingNavigator.ResumeLayout(false);
            this.contratBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faitLeVoyageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faitLeVoyageDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox txtNoContrat;
        private System.Windows.Forms.DateTimePicker dtpDateContrat;
        private System.Windows.Forms.TextBox txtAcompte;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtMontantPaye;
        private System.Windows.Forms.TextBox txtNbPlaces;
        private System.Windows.Forms.ComboBox cboEmployes;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter nosEtNomsEmployesTableAdapter;
        private System.Windows.Forms.BindingSource nosEtNomsEmployesBindingSource;
        private System.Windows.Forms.BindingSource nosEtDestinationsVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter nosEtDestinationsVoyagesTableAdapter;
        private System.Windows.Forms.ComboBox cboVoyages;
        private System.Windows.Forms.BindingSource nosEtDestinationsVoyagesBindingSource1;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.BindingSource nosEtNomsClientsBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter nosEtNomsClientsTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource faitLeVoyageBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.faitLeVoyageTableAdapter faitLeVoyageTableAdapter;
        private System.Windows.Forms.DataGridView faitLeVoyageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAjouter;
    }
}