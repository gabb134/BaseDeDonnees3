namespace Labo4
{
    partial class frmReservationVoyages
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
            this.bDVoyagesMarreroDataSet = new Labo4.BDVoyagesMarreroDataSet();
            this.voyageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voyageTableAdapter = new Labo4.BDVoyagesMarreroDataSetTableAdapters.voyageTableAdapter();
            this.tableAdapterManager = new Labo4.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationsVoyagesTableAdapter = new Labo4.BDVoyagesMarreroDataSetTableAdapters.destinationsVoyagesTableAdapter();
            this.destinationsVoyagesComboBox = new System.Windows.Forms.ComboBox();
            this.infosVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosVoyagesTableAdapter = new Labo4.BDVoyagesMarreroDataSetTableAdapters.infosVoyagesTableAdapter();
            this.dgInfosVoyages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.reservationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationsVoyagesTableAdapter = new Labo4.BDVoyagesMarreroDataSetTableAdapters.reservationsVoyagesTableAdapter();
            this.dgReservationsVoyages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfosVoyages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsVoyages)).BeginInit();
            this.SuspendLayout();
            // 
            // bDVoyagesMarreroDataSet
            // 
            this.bDVoyagesMarreroDataSet.DataSetName = "BDVoyagesMarreroDataSet";
            this.bDVoyagesMarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voyageBindingSource
            // 
            this.voyageBindingSource.DataMember = "voyage";
            this.voyageBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // voyageTableAdapter
            // 
            this.voyageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = null;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Labo4.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = this.voyageTableAdapter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // destinationsVoyagesBindingSource
            // 
            this.destinationsVoyagesBindingSource.DataMember = "destinationsVoyages";
            this.destinationsVoyagesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // destinationsVoyagesTableAdapter
            // 
            this.destinationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // destinationsVoyagesComboBox
            // 
            this.destinationsVoyagesComboBox.DataSource = this.destinationsVoyagesBindingSource;
            this.destinationsVoyagesComboBox.DisplayMember = "voyDestination";
            this.destinationsVoyagesComboBox.FormattingEnabled = true;
            this.destinationsVoyagesComboBox.Location = new System.Drawing.Point(140, 36);
            this.destinationsVoyagesComboBox.Name = "destinationsVoyagesComboBox";
            this.destinationsVoyagesComboBox.Size = new System.Drawing.Size(139, 21);
            this.destinationsVoyagesComboBox.TabIndex = 2;
            this.destinationsVoyagesComboBox.ValueMember = "voyDestination";
            // 
            // infosVoyagesBindingSource
            // 
            this.infosVoyagesBindingSource.DataMember = "destinationsVoyages_infosVoyages";
            this.infosVoyagesBindingSource.DataSource = this.destinationsVoyagesBindingSource;
            // 
            // infosVoyagesTableAdapter
            // 
            this.infosVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // dgInfosVoyages
            // 
            this.dgInfosVoyages.AllowUserToAddRows = false;
            this.dgInfosVoyages.AllowUserToDeleteRows = false;
            this.dgInfosVoyages.AutoGenerateColumns = false;
            this.dgInfosVoyages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInfosVoyages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInfosVoyages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgInfosVoyages.DataSource = this.infosVoyagesBindingSource;
            this.dgInfosVoyages.Location = new System.Drawing.Point(26, 93);
            this.dgInfosVoyages.Name = "dgInfosVoyages";
            this.dgInfosVoyages.ReadOnly = true;
            this.dgInfosVoyages.RowHeadersWidth = 20;
            this.dgInfosVoyages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInfosVoyages.Size = new System.Drawing.Size(633, 143);
            this.dgInfosVoyages.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "voyNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "voyDateDepart";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date de départ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "voyDateArrive";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date d\'arrivée";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Animateur";
            this.dataGridViewTextBoxColumn4.HeaderText = "Animateur";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "voyDestination";
            this.dataGridViewTextBoxColumn5.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hotNom";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hôtel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voyages";
            // 
            // reservationsVoyagesBindingSource
            // 
            this.reservationsVoyagesBindingSource.DataMember = "destinationsVoyages_reservationsVoyages";
            this.reservationsVoyagesBindingSource.DataSource = this.destinationsVoyagesBindingSource;
            // 
            // reservationsVoyagesTableAdapter
            // 
            this.reservationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // dgReservationsVoyages
            // 
            this.dgReservationsVoyages.AllowUserToAddRows = false;
            this.dgReservationsVoyages.AllowUserToDeleteRows = false;
            this.dgReservationsVoyages.AutoGenerateColumns = false;
            this.dgReservationsVoyages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservationsVoyages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservationsVoyages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13});
            this.dgReservationsVoyages.DataSource = this.reservationsVoyagesBindingSource;
            this.dgReservationsVoyages.Location = new System.Drawing.Point(26, 275);
            this.dgReservationsVoyages.Name = "dgReservationsVoyages";
            this.dgReservationsVoyages.ReadOnly = true;
            this.dgReservationsVoyages.RowHeadersWidth = 20;
            this.dgReservationsVoyages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservationsVoyages.Size = new System.Drawing.Size(633, 152);
            this.dgReservationsVoyages.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "No de contrat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "conDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date du contrat";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn9.HeaderText = "No de client";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "voyNo";
            this.dataGridViewTextBoxColumn10.HeaderText = "No de voyage";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "voyDateDepart";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date de départ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "voyDateArrive";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date d\'arrivée";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "voyDestination";
            this.dataGridViewTextBoxColumn14.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "hotNom";
            this.dataGridViewTextBoxColumn13.HeaderText = "Hôtel";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vos voyages réservés";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(357, 37);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(302, 34);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter le voyage sélectionné à vos réservations";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(357, 472);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(302, 34);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer la réservation sélectionnée";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmReservationVoyages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 552);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgReservationsVoyages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgInfosVoyages);
            this.Controls.Add(this.destinationsVoyagesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "frmReservationVoyages";
            this.Text = "Réservation de voyages";
            this.Load += new System.EventHandler(this.frmReservationVoyages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voyageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfosVoyages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservationsVoyages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDVoyagesMarreroDataSet bDVoyagesMarreroDataSet;
        private System.Windows.Forms.BindingSource voyageBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.voyageTableAdapter voyageTableAdapter;
        private BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource destinationsVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.destinationsVoyagesTableAdapter destinationsVoyagesTableAdapter;
        private System.Windows.Forms.ComboBox destinationsVoyagesComboBox;
        private System.Windows.Forms.BindingSource infosVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.infosVoyagesTableAdapter infosVoyagesTableAdapter;
        private System.Windows.Forms.DataGridView dgInfosVoyages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource reservationsVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.reservationsVoyagesTableAdapter reservationsVoyagesTableAdapter;
        private System.Windows.Forms.DataGridView dgReservationsVoyages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}