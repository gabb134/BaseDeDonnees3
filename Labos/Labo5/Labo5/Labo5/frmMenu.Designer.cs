namespace Labo5
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empNoLabel;
            System.Windows.Forms.Label empPrenomLabel;
            System.Windows.Forms.Label empNomLabel;
            System.Windows.Forms.Label empCommLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label totalVentesLabel;
            System.Windows.Forms.Label nbContratLabel;
            System.Windows.Forms.Label plusPetiteVenteLabel;
            System.Windows.Forms.Label plusGrandeVenteLabel;
            System.Windows.Forms.Label moyenneVentesLabel;
            System.Windows.Forms.Label commissionPercueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratoire5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDeValeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDeValeursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDeChampsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDVoyagesMarreroDataSet = new Labo5.BDVoyagesMarreroDataSet();
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
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empNoTextBox = new System.Windows.Forms.TextBox();
            this.empPrenomTextBox = new System.Windows.Forms.TextBox();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.empCommTextBox = new System.Windows.Forms.TextBox();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentesTextBox = new System.Windows.Forms.TextBox();
            this.nbContratTextBox = new System.Windows.Forms.TextBox();
            this.employeTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.contratTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.contratTableAdapter();
            this.plusPetiteVenteTextBox = new System.Windows.Forms.TextBox();
            this.plusGrandeVenteTextBox = new System.Windows.Forms.TextBox();
            this.moyenneVentesTextBox = new System.Windows.Forms.TextBox();
            this.commissionPercueTextBox = new System.Windows.Forms.TextBox();
            empNoLabel = new System.Windows.Forms.Label();
            empPrenomLabel = new System.Windows.Forms.Label();
            empNomLabel = new System.Windows.Forms.Label();
            empCommLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            totalVentesLabel = new System.Windows.Forms.Label();
            nbContratLabel = new System.Windows.Forms.Label();
            plusPetiteVenteLabel = new System.Windows.Forms.Label();
            plusGrandeVenteLabel = new System.Windows.Forms.Label();
            moyenneVentesLabel = new System.Windows.Forms.Label();
            commissionPercueLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empNoLabel.Location = new System.Drawing.Point(38, 90);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new System.Drawing.Size(54, 13);
            empNoLabel.TabIndex = 2;
            empNoLabel.Text = "Numéro:";
            // 
            // empPrenomLabel
            // 
            empPrenomLabel.AutoSize = true;
            empPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empPrenomLabel.Location = new System.Drawing.Point(254, 90);
            empPrenomLabel.Name = "empPrenomLabel";
            empPrenomLabel.Size = new System.Drawing.Size(49, 13);
            empPrenomLabel.TabIndex = 4;
            empPrenomLabel.Text = "Prénom";
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empNomLabel.Location = new System.Drawing.Point(254, 120);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(36, 13);
            empNomLabel.TabIndex = 6;
            empNomLabel.Text = "Nom:";
            // 
            // empCommLabel
            // 
            empCommLabel.AutoSize = true;
            empCommLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empCommLabel.Location = new System.Drawing.Point(38, 120);
            empCommLabel.Name = "empCommLabel";
            empCommLabel.Size = new System.Drawing.Size(72, 13);
            empCommLabel.TabIndex = 12;
            empCommLabel.Text = "Commission";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(38, 163);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 16);
            label1.TabIndex = 14;
            label1.Text = "Contrats";
            // 
            // totalVentesLabel
            // 
            totalVentesLabel.AutoSize = true;
            totalVentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalVentesLabel.Location = new System.Drawing.Point(38, 439);
            totalVentesLabel.Name = "totalVentesLabel";
            totalVentesLabel.Size = new System.Drawing.Size(106, 13);
            totalVentesLabel.TabIndex = 14;
            totalVentesLabel.Text = "Total des ventes:";
            // 
            // nbContratLabel
            // 
            nbContratLabel.AutoSize = true;
            nbContratLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nbContratLabel.Location = new System.Drawing.Point(41, 476);
            nbContratLabel.Name = "nbContratLabel";
            nbContratLabel.Size = new System.Drawing.Size(122, 13);
            nbContratLabel.TabIndex = 15;
            nbContratLabel.Text = "Nombre de contrats:";
            // 
            // plusPetiteVenteLabel
            // 
            plusPetiteVenteLabel.AutoSize = true;
            plusPetiteVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            plusPetiteVenteLabel.Location = new System.Drawing.Point(326, 439);
            plusPetiteVenteLabel.Name = "plusPetiteVenteLabel";
            plusPetiteVenteLabel.Size = new System.Drawing.Size(111, 13);
            plusPetiteVenteLabel.TabIndex = 16;
            plusPetiteVenteLabel.Text = " Plus petite vente:";
            // 
            // plusGrandeVenteLabel
            // 
            plusGrandeVenteLabel.AutoSize = true;
            plusGrandeVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            plusGrandeVenteLabel.Location = new System.Drawing.Point(333, 476);
            plusGrandeVenteLabel.Name = "plusGrandeVenteLabel";
            plusGrandeVenteLabel.Size = new System.Drawing.Size(114, 13);
            plusGrandeVenteLabel.TabIndex = 18;
            plusGrandeVenteLabel.Text = "Plus grande vente:";
            // 
            // moyenneVentesLabel
            // 
            moyenneVentesLabel.AutoSize = true;
            moyenneVentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moyenneVentesLabel.Location = new System.Drawing.Point(595, 439);
            moyenneVentesLabel.Name = "moyenneVentesLabel";
            moyenneVentesLabel.Size = new System.Drawing.Size(128, 13);
            moyenneVentesLabel.TabIndex = 20;
            moyenneVentesLabel.Text = "Moyenne des ventes:";
            // 
            // commissionPercueLabel
            // 
            commissionPercueLabel.AutoSize = true;
            commissionPercueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commissionPercueLabel.Location = new System.Drawing.Point(603, 476);
            commissionPercueLabel.Name = "commissionPercueLabel";
            commissionPercueLabel.Size = new System.Drawing.Size(119, 13);
            commissionPercueLabel.TabIndex = 22;
            commissionPercueLabel.Text = "Commission perçue:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoire5ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratoire5ToolStripMenuItem
            // 
            this.laboratoire5ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listesDeValeursToolStripMenuItem,
            this.listesDeValeursToolStripMenuItem1,
            this.ajoutDeChampsToolStripMenuItem});
            this.laboratoire5ToolStripMenuItem.Name = "laboratoire5ToolStripMenuItem";
            this.laboratoire5ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.laboratoire5ToolStripMenuItem.Text = "Laboratoire 5";
            // 
            // listesDeValeursToolStripMenuItem
            // 
            this.listesDeValeursToolStripMenuItem.Name = "listesDeValeursToolStripMenuItem";
            this.listesDeValeursToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.listesDeValeursToolStripMenuItem.Text = "Listes de valeurs: enregistrement par enregistrement";
            this.listesDeValeursToolStripMenuItem.Click += new System.EventHandler(this.listesDeValeursToolStripMenuItem_Click);
            // 
            // listesDeValeursToolStripMenuItem1
            // 
            this.listesDeValeursToolStripMenuItem1.Name = "listesDeValeursToolStripMenuItem1";
            this.listesDeValeursToolStripMenuItem1.Size = new System.Drawing.Size(348, 22);
            this.listesDeValeursToolStripMenuItem1.Text = "Listes de valeurs: tabulaire";
            this.listesDeValeursToolStripMenuItem1.Click += new System.EventHandler(this.listesDeValeursToolStripMenuItem1_Click);
            // 
            // ajoutDeChampsToolStripMenuItem
            // 
            this.ajoutDeChampsToolStripMenuItem.Name = "ajoutDeChampsToolStripMenuItem";
            this.ajoutDeChampsToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.ajoutDeChampsToolStripMenuItem.Text = "Ajout de champs calculés";
            this.ajoutDeChampsToolStripMenuItem.Click += new System.EventHandler(this.ajoutDeChampsToolStripMenuItem_Click);
            // 
            // employeBindingNavigator
            // 
            this.employeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeBindingNavigator.BindingSource = this.employeBindingSource;
            this.employeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeBindingNavigatorSaveItem});
            this.employeBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.employeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeBindingNavigator.Name = "employeBindingNavigator";
            this.employeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeBindingNavigator.Size = new System.Drawing.Size(910, 25);
            this.employeBindingNavigator.TabIndex = 1;
            this.employeBindingNavigator.Text = "bindingNavigator1";
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
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // bDVoyagesMarreroDataSet
            // 
            this.bDVoyagesMarreroDataSet.DataSetName = "BDVoyagesMarreroDataSet";
            this.bDVoyagesMarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click_1);
            // 
            // empNoTextBox
            // 
            this.empNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNo", true));
            this.empNoTextBox.Location = new System.Drawing.Point(113, 87);
            this.empNoTextBox.Name = "empNoTextBox";
            this.empNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.empNoTextBox.TabIndex = 3;
            // 
            // empPrenomTextBox
            // 
            this.empPrenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empPrenom", true));
            this.empPrenomTextBox.Location = new System.Drawing.Point(329, 87);
            this.empPrenomTextBox.Name = "empPrenomTextBox";
            this.empPrenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.empPrenomTextBox.TabIndex = 5;
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(329, 113);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(100, 20);
            this.empNomTextBox.TabIndex = 7;
            // 
            // empCommTextBox
            // 
            this.empCommTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empComm", true));
            this.empCommTextBox.Location = new System.Drawing.Point(113, 117);
            this.empCommTextBox.Name = "empCommTextBox";
            this.empCommTextBox.Size = new System.Drawing.Size(100, 20);
            this.empCommTextBox.TabIndex = 13;
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataMember = "fk_vendeur";
            this.contratBindingSource.DataSource = this.employeBindingSource;
            // 
            // contratDataGridView
            // 
            this.contratDataGridView.AllowUserToAddRows = false;
            this.contratDataGridView.AllowUserToDeleteRows = false;
            this.contratDataGridView.AutoGenerateColumns = false;
            this.contratDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contratDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contratDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7});
            this.contratDataGridView.DataSource = this.contratBindingSource;
            this.contratDataGridView.Location = new System.Drawing.Point(41, 182);
            this.contratDataGridView.Name = "contratDataGridView";
            this.contratDataGridView.ReadOnly = true;
            this.contratDataGridView.RowHeadersWidth = 40;
            this.contratDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contratDataGridView.Size = new System.Drawing.Size(816, 220);
            this.contratDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "conDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "conMontant";
            this.dataGridViewTextBoxColumn4.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Numéro d\'employé";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // totalVentesTextBox
            // 
            this.totalVentesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "totalVentes", true));
            this.totalVentesTextBox.Location = new System.Drawing.Point(150, 436);
            this.totalVentesTextBox.Name = "totalVentesTextBox";
            this.totalVentesTextBox.Size = new System.Drawing.Size(116, 20);
            this.totalVentesTextBox.TabIndex = 15;
            this.totalVentesTextBox.Text = "N/A";
            this.totalVentesTextBox.TextChanged += new System.EventHandler(this.totalVentesTextBox_TextChanged_1);
            // 
            // nbContratTextBox
            // 
            this.nbContratTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "nbContrat", true));
            this.nbContratTextBox.Location = new System.Drawing.Point(169, 473);
            this.nbContratTextBox.Name = "nbContratTextBox";
            this.nbContratTextBox.Size = new System.Drawing.Size(116, 20);
            this.nbContratTextBox.TabIndex = 16;
            this.nbContratTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbContratTextBox.TextChanged += new System.EventHandler(this.nbContratTextBox_TextChanged);
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = this.employeTableAdapter;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.nosEtNomsEmployesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // contratTableAdapter
            // 
            this.contratTableAdapter.ClearBeforeFill = true;
            // 
            // plusPetiteVenteTextBox
            // 
            this.plusPetiteVenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "plusPetiteVente", true));
            this.plusPetiteVenteTextBox.Location = new System.Drawing.Point(443, 436);
            this.plusPetiteVenteTextBox.Name = "plusPetiteVenteTextBox";
            this.plusPetiteVenteTextBox.Size = new System.Drawing.Size(146, 20);
            this.plusPetiteVenteTextBox.TabIndex = 17;
            this.plusPetiteVenteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.plusPetiteVenteTextBox.TextChanged += new System.EventHandler(this.plusPetiteVenteTextBox_TextChanged);
            // 
            // plusGrandeVenteTextBox
            // 
            this.plusGrandeVenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "plusGrandeVente", true));
            this.plusGrandeVenteTextBox.Location = new System.Drawing.Point(454, 473);
            this.plusGrandeVenteTextBox.Name = "plusGrandeVenteTextBox";
            this.plusGrandeVenteTextBox.Size = new System.Drawing.Size(135, 20);
            this.plusGrandeVenteTextBox.TabIndex = 19;
            this.plusGrandeVenteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.plusGrandeVenteTextBox.TextChanged += new System.EventHandler(this.plusGrandeVenteTextBox_TextChanged);
            // 
            // moyenneVentesTextBox
            // 
            this.moyenneVentesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "moyenneVentes", true));
            this.moyenneVentesTextBox.Location = new System.Drawing.Point(729, 436);
            this.moyenneVentesTextBox.Name = "moyenneVentesTextBox";
            this.moyenneVentesTextBox.Size = new System.Drawing.Size(128, 20);
            this.moyenneVentesTextBox.TabIndex = 21;
            this.moyenneVentesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moyenneVentesTextBox.TextChanged += new System.EventHandler(this.moyenneVentesTextBox_TextChanged);
            // 
            // commissionPercueTextBox
            // 
            this.commissionPercueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "commissionPercue", true));
            this.commissionPercueTextBox.Location = new System.Drawing.Point(728, 473);
            this.commissionPercueTextBox.Name = "commissionPercueTextBox";
            this.commissionPercueTextBox.Size = new System.Drawing.Size(129, 20);
            this.commissionPercueTextBox.TabIndex = 23;
            this.commissionPercueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.commissionPercueTextBox.TextChanged += new System.EventHandler(this.commissionPercueTextBox_TextChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 540);
            this.Controls.Add(commissionPercueLabel);
            this.Controls.Add(this.commissionPercueTextBox);
            this.Controls.Add(moyenneVentesLabel);
            this.Controls.Add(this.moyenneVentesTextBox);
            this.Controls.Add(plusGrandeVenteLabel);
            this.Controls.Add(this.plusGrandeVenteTextBox);
            this.Controls.Add(plusPetiteVenteLabel);
            this.Controls.Add(this.plusPetiteVenteTextBox);
            this.Controls.Add(nbContratLabel);
            this.Controls.Add(this.nbContratTextBox);
            this.Controls.Add(totalVentesLabel);
            this.Controls.Add(this.totalVentesTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.contratDataGridView);
            this.Controls.Add(empNoLabel);
            this.Controls.Add(this.empNoTextBox);
            this.Controls.Add(empPrenomLabel);
            this.Controls.Add(this.empPrenomTextBox);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(empCommLabel);
            this.Controls.Add(this.empCommTextBox);
            this.Controls.Add(this.employeBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu (Marrero)";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratoire5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDeValeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDeValeursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajoutDeChampsToolStripMenuItem;
        private BDVoyagesMarreroDataSet bDVoyagesMarreroDataSet;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.employeTableAdapter employeTableAdapter;
        private BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox empNoTextBox;
        private System.Windows.Forms.TextBox empPrenomTextBox;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.TextBox empCommTextBox;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.contratTableAdapter contratTableAdapter;
        private System.Windows.Forms.DataGridView contratDataGridView;
        private System.Windows.Forms.TextBox totalVentesTextBox;
        private System.Windows.Forms.TextBox nbContratTextBox;
        private System.Windows.Forms.TextBox plusPetiteVenteTextBox;
        private System.Windows.Forms.TextBox plusGrandeVenteTextBox;
        private System.Windows.Forms.TextBox moyenneVentesTextBox;
        private System.Windows.Forms.TextBox commissionPercueTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

