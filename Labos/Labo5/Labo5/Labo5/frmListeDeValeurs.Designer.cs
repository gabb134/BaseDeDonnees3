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
            this.conNoTextBox = new System.Windows.Forms.TextBox();
            this.conDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conAcompteTextBox = new System.Windows.Forms.TextBox();
            this.conMontantTextBox = new System.Windows.Forms.TextBox();
            this.conPayeTextBox = new System.Windows.Forms.TextBox();
            this.conTypeOccTextBox = new System.Windows.Forms.TextBox();
            this.cboEmployes = new System.Windows.Forms.ComboBox();
            this.nosEtNomsEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter();
            this.cboVoyages = new System.Windows.Forms.ComboBox();
            this.nosEtDestinationsVoyagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter();
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
            conAcompteLabel.Size = new System.Drawing.Size(73, 13);
            conAcompteLabel.TabIndex = 5;
            conAcompteLabel.Text = "con Acompte:";
            // 
            // conMontantLabel
            // 
            conMontantLabel.AutoSize = true;
            conMontantLabel.Location = new System.Drawing.Point(187, 169);
            conMontantLabel.Name = "conMontantLabel";
            conMontantLabel.Size = new System.Drawing.Size(70, 13);
            conMontantLabel.TabIndex = 7;
            conMontantLabel.Text = "con Montant:";
            // 
            // conPayeLabel
            // 
            conPayeLabel.AutoSize = true;
            conPayeLabel.Location = new System.Drawing.Point(187, 195);
            conPayeLabel.Name = "conPayeLabel";
            conPayeLabel.Size = new System.Drawing.Size(56, 13);
            conPayeLabel.TabIndex = 9;
            conPayeLabel.Text = "Con Paye:";
            // 
            // conTypeOccLabel
            // 
            conTypeOccLabel.AutoSize = true;
            conTypeOccLabel.Location = new System.Drawing.Point(187, 221);
            conTypeOccLabel.Name = "conTypeOccLabel";
            conTypeOccLabel.Size = new System.Drawing.Size(78, 13);
            conTypeOccLabel.TabIndex = 11;
            conTypeOccLabel.Text = "con Type Occ:";
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
            this.contratBindingNavigator.Size = new System.Drawing.Size(800, 25);
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
            // conNoTextBox
            // 
            this.conNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conNo", true));
            this.conNoTextBox.Location = new System.Drawing.Point(271, 88);
            this.conNoTextBox.Name = "conNoTextBox";
            this.conNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.conNoTextBox.TabIndex = 2;
            // 
            // conDateDateTimePicker
            // 
            this.conDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratBindingSource, "conDate", true));
            this.conDateDateTimePicker.Location = new System.Drawing.Point(271, 114);
            this.conDateDateTimePicker.Name = "conDateDateTimePicker";
            this.conDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.conDateDateTimePicker.TabIndex = 4;
            // 
            // conAcompteTextBox
            // 
            this.conAcompteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conAcompte", true));
            this.conAcompteTextBox.Location = new System.Drawing.Point(271, 140);
            this.conAcompteTextBox.Name = "conAcompteTextBox";
            this.conAcompteTextBox.Size = new System.Drawing.Size(200, 20);
            this.conAcompteTextBox.TabIndex = 6;
            // 
            // conMontantTextBox
            // 
            this.conMontantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conMontant", true));
            this.conMontantTextBox.Location = new System.Drawing.Point(271, 166);
            this.conMontantTextBox.Name = "conMontantTextBox";
            this.conMontantTextBox.Size = new System.Drawing.Size(200, 20);
            this.conMontantTextBox.TabIndex = 8;
            // 
            // conPayeTextBox
            // 
            this.conPayeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "ConPaye", true));
            this.conPayeTextBox.Location = new System.Drawing.Point(271, 192);
            this.conPayeTextBox.Name = "conPayeTextBox";
            this.conPayeTextBox.Size = new System.Drawing.Size(200, 20);
            this.conPayeTextBox.TabIndex = 10;
            // 
            // conTypeOccTextBox
            // 
            this.conTypeOccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "conTypeOcc", true));
            this.conTypeOccTextBox.Location = new System.Drawing.Point(271, 218);
            this.conTypeOccTextBox.Name = "conTypeOccTextBox";
            this.conTypeOccTextBox.Size = new System.Drawing.Size(200, 20);
            this.conTypeOccTextBox.TabIndex = 12;
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
            // frmListeDeValeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.cboVoyages);
            this.Controls.Add(this.cboEmployes);
            this.Controls.Add(conNoLabel);
            this.Controls.Add(this.conNoTextBox);
            this.Controls.Add(conDateLabel);
            this.Controls.Add(this.conDateDateTimePicker);
            this.Controls.Add(conAcompteLabel);
            this.Controls.Add(this.conAcompteTextBox);
            this.Controls.Add(conMontantLabel);
            this.Controls.Add(this.conMontantTextBox);
            this.Controls.Add(conPayeLabel);
            this.Controls.Add(this.conPayeTextBox);
            this.Controls.Add(conTypeOccLabel);
            this.Controls.Add(this.conTypeOccTextBox);
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
        private System.Windows.Forms.TextBox conNoTextBox;
        private System.Windows.Forms.DateTimePicker conDateDateTimePicker;
        private System.Windows.Forms.TextBox conAcompteTextBox;
        private System.Windows.Forms.TextBox conMontantTextBox;
        private System.Windows.Forms.TextBox conPayeTextBox;
        private System.Windows.Forms.TextBox conTypeOccTextBox;
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
    }
}