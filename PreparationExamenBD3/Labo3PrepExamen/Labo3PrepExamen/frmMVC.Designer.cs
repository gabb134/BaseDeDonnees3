﻿namespace Labo3PrepExamen
{
    partial class frmMVC
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
            System.Windows.Forms.Label empNomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMVC));
            this.bDVoyagesMarreroDataSet = new Labo3PrepExamen.BDVoyagesMarreroDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new Labo3PrepExamen.BDVoyagesMarreroDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new Labo3PrepExamen.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnModifierNom = new System.Windows.Forms.Button();
            this.btnSuspendreLiaison = new System.Windows.Forms.Button();
            this.btnReprendreLiaison = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnQuantite = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            empNomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Location = new System.Drawing.Point(140, 83);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(55, 13);
            empNomLabel.TabIndex = 2;
            empNomLabel.Text = "emp Nom:";
            // 
            // bDVoyagesMarreroDataSet
            // 
            this.bDVoyagesMarreroDataSet.DataSetName = "BDVoyagesMarreroDataSet";
            this.bDVoyagesMarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
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
            this.tableAdapterManager.UpdateOrder = Labo3PrepExamen.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
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
            this.employeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeBindingNavigator.Name = "employeBindingNavigator";
            this.employeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.employeBindingNavigator.TabIndex = 0;
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
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click);
            // 
            // employeDataGridView
            // 
            this.employeDataGridView.AutoGenerateColumns = false;
            this.employeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.employeDataGridView.DataSource = this.employeBindingSource;
            this.employeDataGridView.Location = new System.Drawing.Point(93, 139);
            this.employeDataGridView.Name = "employeDataGridView";
            this.employeDataGridView.RowHeadersWidth = 20;
            this.employeDataGridView.Size = new System.Drawing.Size(598, 185);
            this.employeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "empNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "empPrenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "empPrenom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "empNom";
            this.dataGridViewTextBoxColumn3.HeaderText = "empNom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "empEmploi";
            this.dataGridViewTextBoxColumn4.HeaderText = "empEmploi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "empSal";
            this.dataGridViewTextBoxColumn5.HeaderText = "empSal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "empComm";
            this.dataGridViewTextBoxColumn6.HeaderText = "empComm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "empSup";
            this.dataGridViewTextBoxColumn7.HeaderText = "empSup";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "empBureau";
            this.dataGridViewTextBoxColumn8.HeaderText = "empBureau";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(201, 80);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(100, 20);
            this.empNomTextBox.TabIndex = 3;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(457, 79);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 4;
            // 
            // btnModifierNom
            // 
            this.btnModifierNom.Location = new System.Drawing.Point(336, 77);
            this.btnModifierNom.Name = "btnModifierNom";
            this.btnModifierNom.Size = new System.Drawing.Size(110, 23);
            this.btnModifierNom.TabIndex = 5;
            this.btnModifierNom.Text = "Modifier 1er nom";
            this.btnModifierNom.UseVisualStyleBackColor = true;
            this.btnModifierNom.Click += new System.EventHandler(this.btnModifierNom_Click);
            // 
            // btnSuspendreLiaison
            // 
            this.btnSuspendreLiaison.Location = new System.Drawing.Point(221, 347);
            this.btnSuspendreLiaison.Name = "btnSuspendreLiaison";
            this.btnSuspendreLiaison.Size = new System.Drawing.Size(145, 23);
            this.btnSuspendreLiaison.TabIndex = 6;
            this.btnSuspendreLiaison.Text = "Suspendre liaison";
            this.btnSuspendreLiaison.UseVisualStyleBackColor = true;
            this.btnSuspendreLiaison.Click += new System.EventHandler(this.btnSuspendreLiaison_Click);
            // 
            // btnReprendreLiaison
            // 
            this.btnReprendreLiaison.Location = new System.Drawing.Point(388, 347);
            this.btnReprendreLiaison.Name = "btnReprendreLiaison";
            this.btnReprendreLiaison.Size = new System.Drawing.Size(145, 23);
            this.btnReprendreLiaison.TabIndex = 7;
            this.btnReprendreLiaison.Text = "Reprendre liaison";
            this.btnReprendreLiaison.UseVisualStyleBackColor = true;
            this.btnReprendreLiaison.Click += new System.EventHandler(this.btnReprendreLiaison_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(164, 386);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(108, 23);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "Employé précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(51, 386);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(108, 23);
            this.btnPremier.TabIndex = 8;
            this.btnPremier.Text = "premier employé";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(391, 386);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(108, 23);
            this.btnDernier.TabIndex = 11;
            this.btnDernier.Text = "Dernier employé";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(278, 386);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(108, 23);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = "Employé suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnQuantite
            // 
            this.btnQuantite.Location = new System.Drawing.Point(641, 386);
            this.btnQuantite.Name = "btnQuantite";
            this.btnQuantite.Size = new System.Drawing.Size(108, 23);
            this.btnQuantite.TabIndex = 13;
            this.btnQuantite.Text = "Nombre d\'employés";
            this.btnQuantite.UseVisualStyleBackColor = true;
            this.btnQuantite.Click += new System.EventHandler(this.btnQuantite_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(511, 386);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(124, 23);
            this.btnPosition.TabIndex = 12;
            this.btnPosition.Text = "Position de l\'employé";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter un employé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Actualiser l\'employé courant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Supprimer l\'employé courant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuantite);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnReprendreLiaison);
            this.Controls.Add(this.btnSuspendreLiaison);
            this.Controls.Add(this.btnModifierNom);
            this.Controls.Add(this.txt);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(this.employeDataGridView);
            this.Controls.Add(this.employeBindingNavigator);
            this.Name = "frmMVC";
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmMVC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView employeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnModifierNom;
        private System.Windows.Forms.Button btnSuspendreLiaison;
        private System.Windows.Forms.Button btnReprendreLiaison;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnQuantite;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}