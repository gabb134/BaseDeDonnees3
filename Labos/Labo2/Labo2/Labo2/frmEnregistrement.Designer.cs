namespace Labo2
{
    partial class frmEnregistrement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnregistrement));
            System.Windows.Forms.Label empNoLabel;
            System.Windows.Forms.Label empPrenomLabel;
            System.Windows.Forms.Label empNomLabel;
            System.Windows.Forms.Label empEmploiLabel;
            System.Windows.Forms.Label empSalLabel;
            System.Windows.Forms.Label empCommLabel;
            System.Windows.Forms.Label empSupLabel;
            System.Windows.Forms.Label empBureauLabel;
            this.bDVoyagesMarreroDataSet = new Labo2.BDVoyagesMarreroDataSet();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new Labo2.BDVoyagesMarreroDataSetTableAdapters.employeTableAdapter();
            this.tableAdapterManager = new Labo2.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.employeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empNoTextBox = new System.Windows.Forms.TextBox();
            this.empPrenomTextBox = new System.Windows.Forms.TextBox();
            this.empNomTextBox = new System.Windows.Forms.TextBox();
            this.empEmploiTextBox = new System.Windows.Forms.TextBox();
            this.empSalTextBox = new System.Windows.Forms.TextBox();
            this.empCommTextBox = new System.Windows.Forms.TextBox();
            this.empSupTextBox = new System.Windows.Forms.TextBox();
            this.empBureauTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            empNoLabel = new System.Windows.Forms.Label();
            empPrenomLabel = new System.Windows.Forms.Label();
            empNomLabel = new System.Windows.Forms.Label();
            empEmploiLabel = new System.Windows.Forms.Label();
            empSalLabel = new System.Windows.Forms.Label();
            empCommLabel = new System.Windows.Forms.Label();
            empSupLabel = new System.Windows.Forms.Label();
            empBureauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).BeginInit();
            this.employeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.UpdateOrder = Labo2.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.employeBindingNavigator.Size = new System.Drawing.Size(412, 25);
            this.employeBindingNavigator.TabIndex = 0;
            this.employeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // employeBindingNavigatorSaveItem
            // 
            this.employeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeBindingNavigatorSaveItem.Image")));
            this.employeBindingNavigatorSaveItem.Name = "employeBindingNavigatorSaveItem";
            this.employeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.employeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeBindingNavigatorSaveItem_Click);
            // 
            // empNoLabel
            // 
            empNoLabel.AutoSize = true;
            empNoLabel.Location = new System.Drawing.Point(63, 95);
            empNoLabel.Name = "empNoLabel";
            empNoLabel.Size = new System.Drawing.Size(47, 13);
            empNoLabel.TabIndex = 1;
            empNoLabel.Text = "Numéro:";
            // 
            // empNoTextBox
            // 
            this.empNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNo", true));
            this.empNoTextBox.Location = new System.Drawing.Point(138, 92);
            this.empNoTextBox.Name = "empNoTextBox";
            this.empNoTextBox.Size = new System.Drawing.Size(155, 20);
            this.empNoTextBox.TabIndex = 2;
            // 
            // empPrenomLabel
            // 
            empPrenomLabel.AutoSize = true;
            empPrenomLabel.Location = new System.Drawing.Point(63, 121);
            empPrenomLabel.Name = "empPrenomLabel";
            empPrenomLabel.Size = new System.Drawing.Size(46, 13);
            empPrenomLabel.TabIndex = 3;
            empPrenomLabel.Text = "Prénom:";
            // 
            // empPrenomTextBox
            // 
            this.empPrenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empPrenom", true));
            this.empPrenomTextBox.Location = new System.Drawing.Point(138, 118);
            this.empPrenomTextBox.Name = "empPrenomTextBox";
            this.empPrenomTextBox.Size = new System.Drawing.Size(155, 20);
            this.empPrenomTextBox.TabIndex = 4;
            // 
            // empNomLabel
            // 
            empNomLabel.AutoSize = true;
            empNomLabel.Location = new System.Drawing.Point(63, 147);
            empNomLabel.Name = "empNomLabel";
            empNomLabel.Size = new System.Drawing.Size(32, 13);
            empNomLabel.TabIndex = 5;
            empNomLabel.Text = "Nom:";
            // 
            // empNomTextBox
            // 
            this.empNomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empNom", true));
            this.empNomTextBox.Location = new System.Drawing.Point(138, 144);
            this.empNomTextBox.Name = "empNomTextBox";
            this.empNomTextBox.Size = new System.Drawing.Size(155, 20);
            this.empNomTextBox.TabIndex = 6;
            // 
            // empEmploiLabel
            // 
            empEmploiLabel.AutoSize = true;
            empEmploiLabel.Location = new System.Drawing.Point(63, 173);
            empEmploiLabel.Name = "empEmploiLabel";
            empEmploiLabel.Size = new System.Drawing.Size(41, 13);
            empEmploiLabel.TabIndex = 7;
            empEmploiLabel.Text = "Emploi:";
            // 
            // empEmploiTextBox
            // 
            this.empEmploiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empEmploi", true));
            this.empEmploiTextBox.Location = new System.Drawing.Point(138, 170);
            this.empEmploiTextBox.Name = "empEmploiTextBox";
            this.empEmploiTextBox.Size = new System.Drawing.Size(155, 20);
            this.empEmploiTextBox.TabIndex = 8;
            // 
            // empSalLabel
            // 
            empSalLabel.AutoSize = true;
            empSalLabel.Location = new System.Drawing.Point(63, 199);
            empSalLabel.Name = "empSalLabel";
            empSalLabel.Size = new System.Drawing.Size(42, 13);
            empSalLabel.TabIndex = 9;
            empSalLabel.Text = "Salaire:";
            // 
            // empSalTextBox
            // 
            this.empSalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empSal", true));
            this.empSalTextBox.Location = new System.Drawing.Point(138, 196);
            this.empSalTextBox.Name = "empSalTextBox";
            this.empSalTextBox.Size = new System.Drawing.Size(155, 20);
            this.empSalTextBox.TabIndex = 10;
            // 
            // empCommLabel
            // 
            empCommLabel.AutoSize = true;
            empCommLabel.Location = new System.Drawing.Point(63, 225);
            empCommLabel.Name = "empCommLabel";
            empCommLabel.Size = new System.Drawing.Size(65, 13);
            empCommLabel.TabIndex = 11;
            empCommLabel.Text = "Commission:";
            // 
            // empCommTextBox
            // 
            this.empCommTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empComm", true));
            this.empCommTextBox.Location = new System.Drawing.Point(138, 222);
            this.empCommTextBox.Name = "empCommTextBox";
            this.empCommTextBox.Size = new System.Drawing.Size(155, 20);
            this.empCommTextBox.TabIndex = 12;
            // 
            // empSupLabel
            // 
            empSupLabel.AutoSize = true;
            empSupLabel.Location = new System.Drawing.Point(63, 251);
            empSupLabel.Name = "empSupLabel";
            empSupLabel.Size = new System.Drawing.Size(55, 13);
            empSupLabel.TabIndex = 13;
            empSupLabel.Text = "Supérieur:";
            // 
            // empSupTextBox
            // 
            this.empSupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empSup", true));
            this.empSupTextBox.Location = new System.Drawing.Point(138, 248);
            this.empSupTextBox.Name = "empSupTextBox";
            this.empSupTextBox.Size = new System.Drawing.Size(155, 20);
            this.empSupTextBox.TabIndex = 14;
            // 
            // empBureauLabel
            // 
            empBureauLabel.AutoSize = true;
            empBureauLabel.Location = new System.Drawing.Point(63, 277);
            empBureauLabel.Name = "empBureauLabel";
            empBureauLabel.Size = new System.Drawing.Size(44, 13);
            empBureauLabel.TabIndex = 15;
            empBureauLabel.Text = "Bureau:";
            // 
            // empBureauTextBox
            // 
            this.empBureauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeBindingSource, "empBureau", true));
            this.empBureauTextBox.Location = new System.Drawing.Point(138, 274);
            this.empBureauTextBox.Name = "empBureauTextBox";
            this.empBureauTextBox.Size = new System.Drawing.Size(155, 20);
            this.empBureauTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion des employés";
            // 
            // frmEnregistrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(empNoLabel);
            this.Controls.Add(this.empNoTextBox);
            this.Controls.Add(empPrenomLabel);
            this.Controls.Add(this.empPrenomTextBox);
            this.Controls.Add(empNomLabel);
            this.Controls.Add(this.empNomTextBox);
            this.Controls.Add(empEmploiLabel);
            this.Controls.Add(this.empEmploiTextBox);
            this.Controls.Add(empSalLabel);
            this.Controls.Add(this.empSalTextBox);
            this.Controls.Add(empCommLabel);
            this.Controls.Add(this.empCommTextBox);
            this.Controls.Add(empSupLabel);
            this.Controls.Add(this.empSupTextBox);
            this.Controls.Add(empBureauLabel);
            this.Controls.Add(this.empBureauTextBox);
            this.Controls.Add(this.employeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmEnregistrement";
            this.Text = "Affichage enregistrement par enregistrement";
            this.Load += new System.EventHandler(this.frmEnregistrement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingNavigator)).EndInit();
            this.employeBindingNavigator.ResumeLayout(false);
            this.employeBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox empNoTextBox;
        private System.Windows.Forms.TextBox empPrenomTextBox;
        private System.Windows.Forms.TextBox empNomTextBox;
        private System.Windows.Forms.TextBox empEmploiTextBox;
        private System.Windows.Forms.TextBox empSalTextBox;
        private System.Windows.Forms.TextBox empCommTextBox;
        private System.Windows.Forms.TextBox empSupTextBox;
        private System.Windows.Forms.TextBox empBureauTextBox;
        private System.Windows.Forms.Label label1;
    }
}